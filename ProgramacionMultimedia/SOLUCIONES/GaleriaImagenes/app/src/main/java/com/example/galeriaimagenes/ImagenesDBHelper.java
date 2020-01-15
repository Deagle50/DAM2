package com.example.galeriaimagenes;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

public class ImagenesDBHelper extends SQLiteOpenHelper {
    String sentencia="CREATE TABLE Imagenes(Id INTEGER PRIMARY KEY, Nombre TEXT, Firma TEXT)";
    @Override
    public void onCreate(SQLiteDatabase db) {
        db.execSQL(sentencia);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL("DROP TABLE IF EXISTS Imagenes");
        db.execSQL(sentencia);
    }

    public ImagenesDBHelper(@Nullable Context context, @Nullable String name, @Nullable SQLiteDatabase.CursorFactory factory, int version) {
        super(context, name, factory, version);
    }
}
