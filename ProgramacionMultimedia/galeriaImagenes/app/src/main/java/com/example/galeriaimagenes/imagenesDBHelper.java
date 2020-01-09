package com.example.galeriaimagenes;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

public class imagenesDBHelper extends SQLiteOpenHelper {
    String sentencia = "CREATE TABLE Imagenes(Id INTEGER PRIMARY KEY, Imagen TEXT, Titulo TEXT)";
    public imagenesDBHelper(@Nullable Context context, @Nullable String name, @Nullable SQLiteDatabase.CursorFactory factory, int version) {
        super(context, name, factory, version);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        db.execSQL(sentencia);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL("DROP TABLE IF EXISTS imagenes");
        db.execSQL(sentencia);
    }
}
