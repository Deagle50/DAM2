package com.deagle50.coctelpedia.helpers;

import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

import com.deagle50.coctelpedia.R;
import com.deagle50.coctelpedia.helpers.LanguageHelper;
import java.util.ArrayList;

public class CoctelsOpenHelper extends SQLiteOpenHelper {
    private Context context;
    private String crearTablaES = "CREATE TABLE coctelsES(_id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                                "name TEXT," +
                                                "url_photo TEXT," +
                                                "graduation FLOAT," +
                                                "priceH FLOAT," +
                                                "priceB FLOAT," +
                                                "making TEXT," +
                                                "description TEXT," +
                                                "vegetarian BOOLEAN," +
                                                "vegan BOOLEAN," +
                                                "type TEXT);";

    private String crearTablaEN = "CREATE TABLE coctelsEN(_id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                                "name TEXT," +
                                                "url_photo TEXT," +
                                                "graduation FLOAT," +
                                                "priceH FLOAT," +
                                                "priceB FLOAT," +
                                                "making TEXT," +
                                                "description TEXT," +
                                                "vegetarian BOOLEAN," +
                                                "vegan BOOLEAN," +
                                                "type TEXT);";

    private String crearTablaEU = "CREATE TABLE coctelsEN(_id INTEGER PRIMARY KEY AUTOINCREMENT, " +
            "name TEXT," +
            "url_photo TEXT," +
            "graduation FLOAT," +
            "priceH FLOAT," +
            "priceB FLOAT," +
            "making TEXT," +
            "description TEXT," +
            "vegetarian BOOLEAN," +
            "vegan BOOLEAN," +
            "type TEXT);";
    private String insertCoctelsES = "INSERT INTO coctelsES(name, url_photo, graduation, priceH, priceB,making, description, vegetarian, vegan, type)" +
                                    "VALUES ('Coctel nuevo a', " + R.drawable.coctel + ", 37, 4, 6, 'This is an example for the description of the coctel, its flavour and other things', 'Here comes the explanation of how is done the coctel', 1, 0, 'asdf'),"+
                                            "('Coctel nuevo b', " + R.drawable.buttons + ", 37, 5, 3, 'done like this', 'this description', 0, 0, 'cerveza')," +
                                            "('Coctel nuevo ab', 1, 37, 2, 4, 'done like this', 'this description', 1, 1, 'cerveza')";

    private String insertCoctelsEN = "INSERT INTO coctelsEN(name, url_photo, graduation, priceH, priceB,making, description, vegetarian, vegan, type)" +
                                    "VALUES ('New coctel a', " + R.drawable.coctel + ", 37, 4, 6, 'This is an example for the description of the coctel, its flavour and other things', 'Here comes the explanation of how is done the coctel', 1, 0, 'asdf'),"+
                                            "('New coctel b', " + R.drawable.buttons + ", 37, 5, 3, 'done like this', 'this description', 0, 0, 'beer')," +
                                            "('New coctel ab', 1, 37, 2, 4, 'done like this', 'this description', 1, 1, 'beer')";

    private String insertCoctelsEU = "INSERT INTO coctelsEU(name, url_photo, graduation, priceH, priceB,making, description, vegetarian, vegan, type)" +
                                    "VALUES ('Koktel berria a', " + R.drawable.coctel + ", 37, 4, 6, 'This is an example for the description of the coctel, its flavour and other things', 'Here comes the explanation of how is done the coctel', 1, 0, 'asdf'),"+
                                            "('Koktel berria b', " + R.drawable.buttons + ", 37, 5, 3, 'done like this', 'this description', 0, 0, 'garagardoa')," +
                                            "('Koktel berria ab', 1, 37, 2, 4, 'done like this', 'this description', 1, 1, 'garagardoa')";

    public CoctelsOpenHelper(@Nullable Context context, @Nullable String name, @Nullable SQLiteDatabase.CursorFactory factory, int version) {
        super(context, name, factory, version);
        this.context = context;
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        try {
            db.execSQL(crearTablaES);
            db.execSQL(crearTablaEN);
            db.execSQL(crearTablaEU);
            db.execSQL(insertCoctelsES);
            db.execSQL(insertCoctelsEN);
            db.execSQL(insertCoctelsEU);
        } catch (Exception ignored) {
        }
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {

    }

    public Cursor getCoctels(String selection, ArrayList<String> whereArguments, String orderBy) {
        LanguageHelper languageHelper = new LanguageHelper(context);
        String lg = languageHelper.getLanguage(context);
        String table = "";
        SQLiteDatabase db = this.getReadableDatabase();
        return db.rawQuery("SELECT * FROM coctelsEN", null);
        /*
        switch (lg) {
            case "en":
                table = "coctelsEN";
                break;
            case "eu":
                table = "coctelsEU";
                break;
            case "es":
                table = "coctelsES";
                break;
        }

        SQLiteDatabase db = this.getReadableDatabase();
        String[] args = new String[whereArguments.size()];
        args = whereArguments.toArray(args);
        try {
            return db.query(table, null, selection, args, null, null, orderBy);
        }catch (Exception ex) {
            return null;
        }*/
    }

    public Cursor getRandomCoctel()
    {
        LanguageHelper languageHelper = new LanguageHelper(context);
        String lg = languageHelper.getLanguage(context);
        SQLiteDatabase db = this.getReadableDatabase();

        try{
            switch (lg) {
                case "en":
                    return db.rawQuery("SELECT  * FROM coctelsEN WHERE language=? ORDER BY RANDOM() LIMIT 1", null);
                case "eu":
                    return db.rawQuery("SELECT  * FROM coctelsEU WHERE language=? ORDER BY RANDOM() LIMIT 1", null);
                case "es":
                    return db.rawQuery("SELECT  * FROM coctelsES WHERE language=? ORDER BY RANDOM() LIMIT 1", null);
                default:
                    return db.rawQuery("SELECT  * FROM coctelsEN WHERE language=? ORDER BY RANDOM() LIMIT 1", null);
            }
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public Cursor getTypes(){
        SQLiteDatabase db = this.getReadableDatabase();
        String[] type = new String[]{"_id", "type"};
        LanguageHelper languageHelper = new LanguageHelper(context);
        String lg = languageHelper.getLanguage(context);
        String table = "";

        switch (lg) {
            case "en":
                table = "coctelsEN";
                break;
            case "eu":
                table = "coctelsEU";
                break;
            case "es":
                table = "coctelsES";
                break;
        }

        try {
            return db.query(table, type, null, null, "type", null, null);
        }catch (Exception ex) {
            return null;
        }
    }
}
