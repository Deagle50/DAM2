package com.example.ejemplodb;

import androidx.appcompat.app.AppCompatActivity;

import android.content.ContentValues;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class Metodos extends AppCompatActivity implements View.OnClickListener{
    Button btnBuscar, btnInsertar, btnActualizar, btnBorrar;
    EditText txtID, txtNombre;
    SQLiteDatabase db;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_metodos);

        btnInsertar = findViewById(R.id.btnInsert);
        btnActualizar = findViewById(R.id.btnUpdate);
        btnBorrar=findViewById(R.id.btnDelete);
        btnBuscar=findViewById(R.id.btnBuscar);

        txtID = findViewById(R.id.txtID2);
        txtNombre=findViewById(R.id.txtNombre2);

        btnBorrar.setOnClickListener(this);
        btnActualizar.setOnClickListener(this);
        btnInsertar.setOnClickListener(this);
        btnBuscar.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {
        if(v == btnBuscar)
        {
            db = MainActivity.dbHelper.getWritableDatabase();
            Cursor c = db.query("Usuarios", new String[]{"Nombre"}, "id_usuario=?",
                    new String[]{txtID.getText().toString()}, null, null, null);

            if(c.moveToFirst()){
                txtNombre.setText(c.getString(0));
                btnInsertar.setEnabled(false);
                btnActualizar.setEnabled(true);
                btnBorrar.setEnabled(true);
            }
            else{
                btnInsertar.setEnabled(true);
                btnActualizar.setEnabled(false);
                btnBorrar.setEnabled(false);
            }
            db.close();
        }
        else if(v == btnInsertar)
        {
            db=MainActivity.dbHelper.getWritableDatabase();
            ContentValues cv = new ContentValues();
            cv.put("id_usuario", Integer.valueOf(txtID.getText().toString()));
            cv.put("nombre", txtNombre.getText().toString());
            db.insert("Usuarios", null, cv);
            db.close();
        }
        else if(v==btnActualizar){
            db=MainActivity.dbHelper.getWritableDatabase();
            ContentValues cv = new ContentValues();
            cv.put("nombre", txtNombre.getText().toString());

            db.update("Usuarios", cv, "id_usuario=?", new String[]{txtID.getText().toString()});

            db.close();
        }
        else if(v==btnBorrar)
        {
            db=MainActivity.dbHelper.getWritableDatabase();

            db.delete("Usuarios", "id_usuario=?", new String[]{txtID.getText().toString()});

            db.close();
        }
    }
}
