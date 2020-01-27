package com.deagle50.coctelpedia.helpers;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.widget.Toast;

import androidx.annotation.Nullable;

public class CoctelesOpenHelper extends SQLiteOpenHelper {
    public Context context;
    String crearTabla = "CREATE TABLE cocteles(id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                                "Nombre TEXT," +
                                                "url_foto TEXT," +
                                                "graduacion FLOAT," +
                                                "precioC FLOAT," +
                                                "precioB FLOAT," +
                                                "elaboracion TEXT," +
                                                "descripcion TEXT," +
                                                "vegetariano BOOLEAN," +
                                                "vegano BOOLEAN," +
                                                "tipo TEXT);";

    public CoctelesOpenHelper(@Nullable Context context, @Nullable String name, @Nullable SQLiteDatabase.CursorFactory factory, int version) {
        super(context, name, factory, version);
        this.context = context;
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        try {
            db.execSQL(crearTabla);
        } catch (Exception e) {
            Toast.makeText(this.context, "Tabla creada con éxito.", Toast.LENGTH_SHORT).show();
        }
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {

    }

    public Cursor obtenerCocteles() {
        SQLiteDatabase db = this.getReadableDatabase();
        try {
            Cursor c = db.query("cocteles", null, null, null, null, null, null);
            return c;
        }catch (Exception ex) {
            return null;
        }
    }

}
