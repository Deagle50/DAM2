package com.example.ejemplodb;

import androidx.appcompat.app.AppCompatActivity;

import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Button;
import android.database.Cursor;

public class Consultas extends AppCompatActivity implements View.OnClickListener {
    Button btnInsert, btnUpdate, btnDelete, btnBuscar;
    EditText txtID, txtNombre;
    SQLiteDatabase db;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_consultas);
        btnInsert = findViewById(R.id.btnInsert);
        btnUpdate = findViewById(R.id.btnUpdate);
        btnDelete=findViewById(R.id.btnDelete);
        btnBuscar=findViewById(R.id.btnBuscar);

        txtID = findViewById(R.id.txtID);
        txtNombre=findViewById(R.id.txtNombre);

        btnDelete.setOnClickListener(this);
        btnUpdate.setOnClickListener(this);
        btnInsert.setOnClickListener(this);
        btnBuscar.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {
        if(v == btnDelete)
        {
            borrar();
        }else if(v == btnUpdate)
        {
            actualizar();
        }
        else if(v==btnInsert)
        {
            insertar();
        }
        else if(v==btnBuscar)
        {
            buscar();
        }
    }


    private void borrar() {
        db = MainActivity.dbHelper.getWritableDatabase();
        db.execSQL("DELETE From Usuarios WHERE id_usuario = ?",
                new Object[]{txtID.getText().toString()});
        db.close();
    }

    private void actualizar() {
        db = MainActivity.dbHelper.getWritableDatabase();
        db.execSQL("UPDATE Usuarios SET nombre=? WHERE id_usuario = ?", new Object[]{txtID.getText().toString(), txtNombre.getText().toString()});
        db.close();
    }

    private void insertar() {
        db = MainActivity.dbHelper.getWritableDatabase();
        db.execSQL("INSERT INTO Usuarios(id_usuario, nombre) VALUES (?,?)", new Object[]{txtID.getText().toString(), txtNombre.getText().toString()});
        db.close();
    }

    private void buscar() {
        Cursor c;
        db = MainActivity.dbHelper.getReadableDatabase();
        c = db.rawQuery("SELECT nombre FROM Usuarios WHERE id_usuario = ?",
                new String[]{txtID.getText().toString()});
        if(c.moveToFirst()){
            txtNombre.setText(c.getString(0));
            btnInsert.setEnabled(false);
            btnUpdate.setEnabled(true);
            btnDelete.setEnabled(true);
        }
        else{
            btnInsert.setEnabled(true);
            btnUpdate.setEnabled(false);
            btnDelete.setEnabled(false);
        }
        db.close();
    }
}
