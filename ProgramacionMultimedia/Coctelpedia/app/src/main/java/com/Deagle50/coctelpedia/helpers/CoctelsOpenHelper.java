package com.deagle50.coctelpedia.helpers;

import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.widget.Toast;

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
                                                "type TEXT);";
    private String insertCoctels = "INSERT INTO coctels(name, url_photo, graduation, priceH, priceB,making, description, vegetarian, vegan, type)" +
                                    "VALUES ('Coctel nuevo a', " + R.drawable.coctel + ", 37, 4, 6, 'This is an example for the description of the coctel, its flavour and other things', 'Here comes the explanation of how is done the coctel', 1, 0, 'asdf'),"+
                                            "('Coctel nuevo b', " + R.drawable.buttons + ", 37, 5, 3, 'done like this', 'this description', 0, 0, 'beer')," +
                                            "('Coctel nuevo ab', 1, 37, 2, 4, 'done like this', 'this description', 1, 1, 'beer')";

    public CoctelsOpenHelper(@Nullable Context context, @Nullable String name, @Nullable SQLiteDatabase.CursorFactory factory, int version) {
        super(context, name, factory, version);
        this.context = context;
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        try {
            db.execSQL(crearTabla);
            db.execSQL(insertCoctels);
        } catch (Exception ignored) {
        }
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {

    }

    public Cursor getCoctels(String selection, ArrayList<String> whereArguments, String orderBy) {
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
        SQLiteDatabase db = this.getReadableDatabase();
        try{
            return db.rawQuery("SELECT  * FROM coctels ORDER BY RANDOM() LIMIT 1", null);
        }
        catch (Exception ex)
        {
            return null;
        }
    }

    public Cursor getTypes(){
        SQLiteDatabase db = this.getReadableDatabase();
        String[] type = new String[]{"_id", "type"};
        try {
            return db.query("coctels", type, null, null, "type", null, null);
        }catch (Exception ex) {
            return null;
        }
    }
}
