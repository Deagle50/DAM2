package com.deagle50.coctelpedia.helpers;

import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

import com.deagle50.coctelpedia.R;
import java.util.ArrayList;

public class CoctelsOpenHelper extends SQLiteOpenHelper {
    private Context context;
    private String crearTabla = "CREATE TABLE coctels(_id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                                                "name TEXT," +
                                                "url_photo TEXT," +
                                                "graduation FLOAT," +
                                                "priceH FLOAT," +
                                                "priceB FLOAT," +
                                                "making TEXT," +
                                                "description TEXT," +
                                                "vegetarian BOOLEAN," +
                                                "vegan BOOLEAN," +
                                                "type TEXT," +
                                                "language TEXT);";
    private String insertCoctelsES = "INSERT INTO coctels(name, url_photo, graduation, priceH, priceB,making, description, vegetarian, vegan, type, language)" +
                                    "VALUES ('Coctel nuevo a', " + R.drawable.coctel + ", 37, 4, 6, 'This is an example for the description of the coctel, its flavour and other things', 'Here comes the explanation of how is done the coctel', 1, 0, 'asdf', 'es'),"+
                                            "('Coctel nuevo b', " + R.drawable.buttons + ", 37, 5, 3, 'done like this', 'this description', 0, 0, 'cerveza', 'es')," +
                                            "('Coctel nuevo ab', 1, 37, 2, 4, 'done like this', 'this description', 1, 1, 'cerveza', 'es')";

    private String insertCoctelsEN = "INSERT INTO coctels(name, url_photo, graduation, priceH, priceB,making, description, vegetarian, vegan, type, language)" +
            "VALUES ('New coctel a', " + R.drawable.coctel + ", 37, 4, 6, 'This is an example for the description of the coctel, its flavour and other things', 'Here comes the explanation of how is done the coctel', 1, 0, 'asdf', 'en'),"+
            "('New coctel b', " + R.drawable.buttons + ", 37, 5, 3, 'done like this', 'this description', 0, 0, 'beer', 'en')," +
            "('New coctel ab', 1, 37, 2, 4, 'done like this', 'this description', 1, 1, 'beer', 'en')";

    private String insertCoctelsEU = "INSERT INTO coctels(name, url_photo, graduation, priceH, priceB,making, description, vegetarian, vegan, type, language)" +
            "VALUES ('Koktel berria a', " + R.drawable.coctel + ", 37, 4, 6, 'This is an example for the description of the coctel, its flavour and other things', 'Here comes the explanation of how is done the coctel', 1, 0, 'asdf', 'eu'),"+
            "('Koktel berria b', " + R.drawable.buttons + ", 37, 5, 3, 'done like this', 'this description', 0, 0, 'garagardoa', 'eu')," +
            "('Koktel berria ab', 1, 37, 2, 4, 'done like this', 'this description', 1, 1, 'garagardoa', 'eu')";

    public CoctelsOpenHelper(@Nullable Context context, @Nullable String name, @Nullable SQLiteDatabase.CursorFactory factory, int version) {
        super(context, name, factory, version);
        this.context = context;
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        try {
            db.execSQL(crearTabla);
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

        if(selection.equals(""))
        {
            selection+= "language =?";
            whereArguments.add(lg);
        }
        else{
            selection += "AND language =?";
            whereArguments.add(lg);
        }

        SQLiteDatabase db = this.getReadableDatabase();
        String[] args = new String[whereArguments.size()];
        args = whereArguments.toArray(args);
        try {
            return db.query("coctels", null, selection, args, null, null, orderBy);
        }catch (Exception ex) {
            return null;
        }
    }

    public Cursor getRandomCoctel()
    {
        LanguageHelper languageHelper = new LanguageHelper(context);

        SQLiteDatabase db = this.getReadableDatabase();
        try{
            return db.rawQuery("SELECT  * FROM coctels WHERE language=? ORDER BY RANDOM() LIMIT 1", new String[]{languageHelper.getLanguage(context)});
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
        String selection = "language=?";
        String[] whereArguments= new String[]{languageHelper.getLanguage(context)};

        try {
            return db.query("coctels", type, selection, whereArguments, "type", null, null);
        }catch (Exception ex) {
            return null;
        }
    }
}
