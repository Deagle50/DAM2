package com.example.imagenes;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import android.Manifest;
import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.graphics.drawable.BitmapDrawable;
import android.net.Uri;
import android.os.Bundle;
import android.provider.MediaStore;
import android.view.MotionEvent;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.Toast;

import java.io.IOException;

public class MainActivity extends AppCompatActivity implements View.OnClickListener, View.OnTouchListener{
    Button btnBuscar, btnGuardar;
    ImageView imagen;
    Canvas c;
    Bitmap copia;
    float rx, ry, x, y;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        btnBuscar = findViewById(R.id.btnBuscar);
        btnGuardar = findViewById(R.id.btnGuardar);
        imagen = findViewById(R.id.imgView);

        btnGuardar.setOnClickListener(this);
        btnBuscar.setOnClickListener(this);
        imagen.setOnTouchListener(this);


    }

    @Override
    public void onClick(View v) {
        if(v == btnBuscar)
        {
            //BUSCAR
            this.requestPermissions(new String[]{Manifest.permission.READ_EXTERNAL_STORAGE,
                    Manifest.permission.WRITE_EXTERNAL_STORAGE}, 123);

            Intent i = new Intent(Intent.ACTION_PICK, MediaStore.Images.Media.EXTERNAL_CONTENT_URI);
            i.setType(MediaStore.Images.Media.CONTENT_TYPE);
            startActivityForResult(i, 1);
        }
        else if(v== btnGuardar)
        {
            //GUARDAR
            MediaStore.Images.Media.insertImage(getContentResolver(), copia, "copia",
                    "copia editada");
            /*Toast t = new Toast(this);
            t.setDuration(Toast.LENGTH_SHORT);
            t.setText("Guardada con éxito");
            t.show();*/

        }
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {
        if(requestCode==1)
        {
            if(resultCode==RESULT_OK)
            {
                try {
                    Uri uri = data.getData();
                    Bitmap foto = MediaStore.Images.Media.getBitmap(getContentResolver(), uri);
                    imagen.setImageBitmap(foto);
                    copia = ((BitmapDrawable)(imagen.getDrawable())).getBitmap().copy(
                            Bitmap.Config.ARGB_8888, true);
                    rx = foto.getWidth()/(float)imagen.getWidth();
                    ry = foto.getHeight()/(float)imagen.getHeight();
                    c = new Canvas(copia);
                }
                catch(java.io.IOException ex)
                {
                    ex.printStackTrace();
                }
            }
        }
        super.onActivityResult(requestCode, resultCode, data);
    }

    @Override
    public boolean onTouch(View v, MotionEvent event){
        if(event.getAction()==MotionEvent.ACTION_DOWN)
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
            imagen.setImageBitmap(copia);
        }
        return true;
    }

}
