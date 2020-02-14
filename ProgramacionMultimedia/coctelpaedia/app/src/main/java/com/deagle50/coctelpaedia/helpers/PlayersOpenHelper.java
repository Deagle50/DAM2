package com.deagle50.coctelpaedia.helpers;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

public class PlayersOpenHelper extends SQLiteOpenHelper {
    String createTable = "CREATE TABLE players(id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT)";
    String deleteTable = "DROP TABLE IF EXISTS players";

    //Constructor
    public PlayersOpenHelper(@Nullable Context context) {
        super(context, "playersDB", null, 1);
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

    public String getRandomPlayer(){
        SQLiteDatabase db = this.getReadableDatabase();

        try{
           Cursor c = db.rawQuery("SELECT  * FROM players ORDER BY RANDOM() LIMIT 1", null);
           c.moveToFirst();
           return c.getString(1);
        }
        catch (Exception ex)
        {
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

    public boolean updatePlayer(int id, String name) {
        SQLiteDatabase db = this.getWritableDatabase();
        String[] args = {name, String.valueOf(id)};
        try {
            db.execSQL("UPDATE players SET name=? WHERE id = ?", args);
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
