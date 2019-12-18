package com.example.ejemplodb;

import androidx.appcompat.app.AppCompatActivity;

import android.content.ContentValues;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class Mensajes extends AppCompatActivity implements View.OnClickListener{
    Button btnInsertar;
    EditText txtUsuario, txtContenido;
    SQLiteDatabase db;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_mensajes);
        txtContenido = findViewById(R.id.txtContenido);
        txtUsuario = findViewById(R.id.txtUsuario);

        btnInsertar = findViewById(R.id.btnInsertar);
        btnInsertar.setOnClickListener(this);


    }

    @Override
    public void onClick(View v) {
        db = MainActivity.dbHelper.getWritableDatabase();
        int id = CalcularIDMensaje();
        ContentValues cv = new ContentValues();
        cv.put("Id_mensaje", id);
        cv.put("mensaje", txtContenido.getText().toString());
        db.insert("Mensajes", null, cv);
        Toast.makeText(this, String.format("Mensaje %d Insertado con éxito", id),
                Toast.LENGTH_LONG).show();
    }

    private int CalcularIDMensaje() {
        db= MainActivity.dbHelper.getReadableDatabase();
        Cursor c = db.rawQuery("SELECT MAX(id_mensaje) FROM Mensajes", null);
        if(c.moveToNext())
        {
            return c.getInt(0)+1;
        }
        return 1;
    }
}
