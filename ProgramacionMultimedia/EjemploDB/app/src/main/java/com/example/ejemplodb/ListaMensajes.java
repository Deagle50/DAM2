package com.example.ejemplodb;

import androidx.appcompat.app.AppCompatActivity;

import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.widget.CursorAdapter;
import android.widget.ListView;
import android.widget.SimpleCursorAdapter;

public class ListaMensajes extends AppCompatActivity {
    ListView lv;
    SQLiteDatabase db;
    Cursor c;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_lista_mensajes);
        lv = findViewById(R.id.lvMensajes);
        db = MainActivity.dbHelper.getReadableDatabase();
        c = db.rawQuery("SELECT id_usuario, id_mensaje AS _id, mensaje FROM Mensajes", null);
        CursorAdapter ca = new SimpleCursorAdapter(this, R.layout.linealayout,c,
                new String[]{"id_usuario", "id_mensaje", "mensaje"},
                new int[]{R.id.txtUsuario, R.id.txtMensaje, R.id.txtContenido}, CursorAdapter.FLAG_REGISTER_CONTENT_OBSERVER);
        lv.setAdapter(ca);
    }
}
