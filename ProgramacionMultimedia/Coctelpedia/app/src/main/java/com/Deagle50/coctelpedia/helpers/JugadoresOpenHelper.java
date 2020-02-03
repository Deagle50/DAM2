package com.deagle50.coctelpedia.helpers;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

public class JugadoresOpenHelper extends SQLiteOpenHelper {
    String crearTabla = "CREATE TABLE jugadores(id INTEGER PRIMARY KEY AUTOINCREMENT, nombre TEXT)";
    String borrarTabla = "DROP TABLE IF EXISTS jugadores";
    //Constructor
    public JugadoresOpenHelper(@Nullable Context context, @Nullable String name, @Nullable SQLiteDatabase.CursorFactory factory, int version) {
        super(context, name, factory, version);
    }


    @Override
    public void onCreate(SQLiteDatabase db) {
        db.execSQL(crearTabla);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        //db.execSQL(borrarTabla);
        //db.execSQL(crearTabla);
    }

    public Cursor obtenerJugadores() {
        SQLiteDatabase db = this.getReadableDatabase();
        try {
            Cursor c = db.query("jugadores", null, null, null, null, null, null);
            return c;
        }catch (Exception ex) {
            return null;
        }
    }

    public boolean borrarJugador(int id) {
        SQLiteDatabase db = this.getWritableDatabase();
        String[] argumentos = {String.valueOf(id)};
        try {
            db.delete("jugadores", "_id = ?", argumentos);
            return true;
        }catch(Exception ex) {
            return false;
        }
    }


    public void insertarJugador(String jugador){
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues cv = new ContentValues();
        cv.put("nombre", jugador);
        db.insert("jugadores", null, cv);
    }
}
