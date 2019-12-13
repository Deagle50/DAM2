package com.example.ejemplodb;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;

public class MainActivity extends AppCompatActivity {
    public static UsuariosOpenHelper dbHelper;
    public static String dbName = "dbUsuarios";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        dbHelper = new UsuariosOpenHelper(this, dbName, null, 1);

        SQLiteDatabase bd = dbHelper.getReadableDatabase();
        setContentView(R.layout.activity_main);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.menu, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        if(item == findViewById(R.id.mnuConsultas))
        {
            Intent i = new Intent(this, Consultas.class);
            startActivity(i);
        }
        else if(item == findViewById(R.id.mnuMetodos)){

        }
        return true;
    }
}
