package com.example.galeriaimagenes;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import android.content.ContentResolver;
import android.content.ContentValues;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.ImageDecoder;
import android.graphics.Paint;
import android.graphics.drawable.BitmapDrawable;
import android.net.Uri;
import android.os.Bundle;
import android.provider.MediaStore;
import android.util.Base64;
import android.view.MotionEvent;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.Toast;

import java.io.ByteArrayOutputStream;

import static java.lang.Integer.parseInt;

public class MainActivity extends AppCompatActivity implements View.OnClickListener, View.OnTouchListener {
    Button btnSave,btnSearch, btnEdit;
    EditText txtID,txtNombre;
    ImageView imgImagen;
    //DB
    ImagenesDBHelper idbh;
    String nombre = "", firma = "";
    Bitmap copia;
    //OnTouch
    float x,y,rx,ry;
    Canvas c;
    boolean nueva=true;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        btnSave=findViewById(R.id.btnSave);
        btnSearch=findViewById(R.id.btnSearch);
        btnEdit = findViewById(R.id.btnEdit);
        imgImagen=findViewById(R.id.imageView);
        txtID=findViewById(R.id.txtID);
        txtNombre=findViewById(R.id.txtNombre);

        btnSave.setOnClickListener(this);
        btnSearch.setOnClickListener(this);
        btnEdit.setOnClickListener(this);
        imgImagen.setOnTouchListener(this);

        idbh=new ImagenesDBHelper(this,"DBGaleria",null,1);
    }

    @Override
    public void onClick(View v) {
        if(btnSearch==v)
        {
            SQLiteDatabase db=idbh.getReadableDatabase();
            Cursor c=db.rawQuery("SELECT Nombre, firma FROM Imagenes Where Id=?",
                    new String[]{(txtID.getText().toString())});
            if(c.moveToFirst())
            {
                txtID.setText(c.getString(0));

                byte []res=Base64.decode(c.getString(1),Base64.DEFAULT);
                Bitmap bmp= BitmapFactory.decodeByteArray(res,0,res.length);
                imgImagen.setImageBitmap(bmp);
                nueva=false;
            }
            else
            {
                nueva = true;
                Toast.makeText(this, "Nueva persona", Toast.LENGTH_SHORT).show();
            }
        }
        else if(btnSave==v)
        {
            guardarImgBD();
            MediaStore.Images.Media.insertImage(getContentResolver(),copia,nombre, firma);

        }
        else if(btnEdit==v)
        {

        }

    }

    private void guardarImgBD() {
        Bitmap bmp=((BitmapDrawable)imgImagen.getDrawable()).getBitmap();
        ByteArrayOutputStream baos=new ByteArrayOutputStream();
        bmp.compress(Bitmap.CompressFormat.JPEG,100,baos);
        byte []array=baos.toByteArray();
        String strfoto=Base64.encodeToString(array,Base64.DEFAULT);
        ContentValues cv=new ContentValues();
        cv.put("Id", parseInt(txtID.getText().toString()));
        cv.put("Nombre",txtNombre.getText().toString());
        cv.put("Firma",strfoto);

        SQLiteDatabase db=idbh.getWritableDatabase();
        db.insert("Imagenes",null,cv);
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {
        if(requestCode==1)
        {
            if(resultCode==RESULT_OK)
            {
                //Uri uri=data.getData();
                try {
                    /*ContentResolver cr=getContentResolver();
                    Bitmap bmp=ImageDecoder.decodeBitmap(ImageDecoder.createSource(cr,uri));*/
                    Bitmap foto = ((BitmapDrawable)imgImagen.getDrawable()).getBitmap();
                    //imgImagen.setImageBitmap(bmp);
                    copia=((BitmapDrawable)(imgImagen.getDrawable())).getBitmap().copy(Bitmap.Config.ARGB_8888,true);
                    rx=foto.getWidth()/(float)imgImagen.getWidth();
                    ry=foto.getHeight()/(float)imgImagen.getHeight();
                    c=new Canvas(copia);
                    /*Cursor c=cr.query(uri,
                                        new String[]{MediaStore.Images.ImageColumns.DISPLAY_NAME},
                                null,
                             null,
                                null);
                    if (c.moveToFirst())
                    {
                       txtID.setText(c.getString(0));
                    }*/
                } catch (Exception e) {
                    e.printStackTrace();
                }
            }
        }
        super.onActivityResult(requestCode, resultCode, data);
    }

    @Override
    public boolean onTouch(View v, MotionEvent event) {

        if (event.getAction()==MotionEvent.ACTION_DOWN)
        {
            x=rx*event.getX();
            y=ry*event.getY();

        }
        else if(event.getAction()==MotionEvent.ACTION_MOVE)
        {
            Paint p=new Paint();
            p.setColor(Color.BLACK);
            c.drawLine(x,y,rx*event.getX(),ry*event.getY(),p);
            x=rx*event.getX();
            y=ry*event.getY();
            imgImagen.setImageBitmap(copia);
        }

        return true;
    }
}
