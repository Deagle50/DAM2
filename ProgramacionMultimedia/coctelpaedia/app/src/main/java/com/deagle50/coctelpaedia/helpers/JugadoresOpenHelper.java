package com.deagle50.coctelpaedia.helpers;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

public class JugadoresOpenHelper extends SQLiteOpenHelper {
    String createTable = "CREATE TABLE players(id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT)";
    String deleteTable = "DROP TABLE IF EXISTS players";
    //Constructor
    public JugadoresOpenHelper(@Nullable Context context, @Nullable String name, @Nullable SQLiteDatabase.CursorFactory factory, int version) {
        super(context, name, factory, version);
    }


    @Override
    public void onCreate(SQLiteDatabase db) {
        db.execSQL(createTable);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL(deleteTable);
        db.execSQL(createTable);
    }

    public Cursor getPlayers() {
        SQLiteDatabase db = this.getReadableDatabase();
        try {
            Cursor c = db.query("players", null, null, null, null, null, null);
            return c;
        }catch (Exception ex) {
            return null;
        }
    }

    public boolean deletePlayer(int id) {
        SQLiteDatabase db = this.getWritableDatabase();
        String[] args = {String.valueOf(id)};
        try {
            db.delete("players", "id = ?", args);
            return true;
        }catch(Exception ex) {
            return false;
        }
    }


    public void insertPlayer(String player){
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues cv = new ContentValues();
        cv.put("name", player);
        db.insert("players", null, cv);
    }
}
