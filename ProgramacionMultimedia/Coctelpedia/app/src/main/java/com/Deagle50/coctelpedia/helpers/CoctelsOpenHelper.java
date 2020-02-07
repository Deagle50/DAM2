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

    private String crearTablaEU = "CREATE TABLE coctelsEU(_id INTEGER PRIMARY KEY AUTOINCREMENT, " +
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
                                    "VALUES ('Mojito', "+R.drawable.ic_coctel_mojito+", 40, 2.5, 5, 'En una copa de cóctel, poner hielo picado 4cl de ron blanco, 3cl de zumo de lima, unas hojas de menta, azúcar al gusto, remover y disfrutar.', 'Uno de los cócteles más conocidos, tiene un toque a menta que no deja indiferente.', 0, 0, 'Coctel'),"+
                                            "('Daiquiri',  "+R.drawable.ic_coctel_daiquiri+", 40, 2.2, 5, 'En la copa, añadir 4cl de ron blanco, zumo de limón natural y azúcar al gusto. Frotar el borde de la copa con el limón le da un toque ácido espectacular.', 'Cóctel también muy reconocido, que tiene un sabor con una mezcla ácida y dulce que gustará a los paladares más exquisitos.', 0, 0, 'Coctel')," +
                                            "('Ginkas',  "+R.drawable.ic_longdrink_ginkas+", 37.5, 2.5, 7, 'Añadir hielo, de 5 a 7 cl de Ginebra, y unos 20cl de kas o fanta (refresco) de limón, con una rodaja de limón en vaso de sidra/cubata/copa grande.', 'Cubata con toque ácido, de sabor agradable, muy popular entre los jóvenes.', 0, 0, 'Combinado')," +
                                            "('Blue Hawaii',  "+R.drawable.ic_coctel_blue_hawaii+", 37, 3, 7, 'Mezclar 6cl de ron , 3 de Curaçao azul, 6 de zumo de piña, 3 de zumo de naranja y hielo.', 'Típico cóctel de color azul eléctrico con un paraguas como adorno, de sabor dulce y reconocido por todos.', 0, 0, 'Coctel')";

    private String insertCoctelsEN = "INSERT INTO coctelsEN(name, url_photo, graduation, priceH, priceB,making, description, vegetarian, vegan, type)" +
            "VALUES ('Mojito', "+R.drawable.ic_coctel_mojito+", 40, 2.5, 5, 'En una copa de cóctel, poner hielo picado 4cl de ron blanco, 3cl de zumo de lima, unas hojas de menta, azúcar al gusto, remover y disfrutar.', 'Uno de los cócteles más conocidos, tiene un toque a menta que no deja indiferente.', 0, 0, 'Cocktail'),"+
            "('Daiquiri',  "+R.drawable.ic_coctel_daiquiri+", 40, 2.2, 5, 'En la copa, añadir 4cl de ron blanco, zumo de limón natural y azúcar al gusto. Frotar el borde de la copa con el limón le da un toque ácido espectacular.', 'Cóctel también muy reconocido, que tiene un sabor con una mezcla ácida y dulce que gustará a los paladares más exquisitos.', 0, 0, 'Cocktail')," +
            "('Blue Hawaii',  "+R.drawable.ic_coctel_blue_hawaii+", 37, 3, 7, 'Mezclar 6cl de ron , 3 de Curaçao azul, 6 de zumo de piña, 3 de zumo de naranja y hielo.', 'Típico cóctel de color azul eléctrico con un paraguas como adorno, de sabor dulce y reconocido por todos', 0, 0, 'Cocktail')";

    private String insertCoctelsEU = "INSERT INTO coctelsEU(name, url_photo, graduation, priceH, priceB,making, description, vegetarian, vegan, type)" +
            "VALUES ('Mojito', "+R.drawable.ic_coctel_mojito+", 40, 2.5, 5, 'En una copa de cóctel, poner hielo picado 4cl de ron blanco, 3cl de zumo de lima, unas hojas de menta, azúcar al gusto, remover y disfrutar.', 'Uno de los cócteles más conocidos, tiene un toque a menta que no deja indiferente.', 0, 0, 'Koktel'),"+
            "('Daiquiri',  "+R.drawable.ic_coctel_daiquiri+", 40, 2.2, 5, 'En la copa, añadir 4cl de ron blanco, zumo de limón natural y azúcar al gusto. Frotar el borde de la copa con el limón le da un toque ácido espectacular.', 'Cóctel también muy reconocido, que tiene un sabor con una mezcla ácida y dulce que gustará a los paladares más exquisitos.', 0, 0, 'Koktel')," +
            "('Blue Hawaii',  "+R.drawable.ic_coctel_blue_hawaii+", 37, 3, 7, 'Mezclar 6cl de ron , 3 de Curaçao azul, 6 de zumo de piña, 3 de zumo de naranja y hielo', 'Típico cóctel de color azul eléctrico con un paraguas como adorno, de sabor dulce y reconocido por todos.', 0, 0, 'Koktel')";

    public CoctelsOpenHelper(@Nullable Context context) {
        super(context, "cursorCoctels", null, 1);
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

        /*
        * Ñapa: If whereArguments is empty, it will make "args" null,
        * so that way it will always return the query
        * (previously was returning empty cursors)

         */
        String[] args = new String[whereArguments.size()];
        if(whereArguments.size()==0)
        {
            args=null;
        }
        else{
            args = whereArguments.toArray(args);
        }

        try {
            return db.query(table, null, selection, args, null, null, orderBy);
        }catch (Exception ex) {
            return null;
        }
    }

    public Cursor getRandomCoctel()
    {
        LanguageHelper languageHelper = new LanguageHelper(context);
        String lg = languageHelper.getLanguage(context);
        SQLiteDatabase db = this.getReadableDatabase();

        try{
            switch (lg) {
                case "eu":
                    return db.rawQuery("SELECT  * FROM coctelsEU ORDER BY RANDOM() LIMIT 1", null);
                case "es":
                    return db.rawQuery("SELECT  * FROM coctelsES ORDER BY RANDOM() LIMIT 1", null);
                default:
                    return db.rawQuery("SELECT  * FROM coctelsEN ORDER BY RANDOM() LIMIT 1", null);
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
