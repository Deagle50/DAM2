package com.example.ejemplodb;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

public class UsuariosOpenHelper extends SQLiteOpenHelper {
    String crearUsuarios= "CREATE TABLE Usuarios (id_usuario INTEGER PRIMARY KEY, nombre TEXT)";
    String crearMensajes = "CREATE TABLE Mensajes (id_mensaje INTEGER PRIMARY KEY, mensaje TEXT," +
                            "id_usuario INTEGER, FOREIGN KEY (id_usuario) REFERENCES " +
                            "Usuarios(id_usuario))";
    String crearTrigger = "CREATE TRIGGER FK_Mensajes_Usuarios BEFORE INSERT ON Mensajes" +
                            " BEGIN " +
                            "SELECT RAISE (ABORT, 'No existe elemento relacionado') " +
                            "WHERE new.id_usuario IS NULL OR " +
                            "(SELECT id_usuario FROM Usuarios WHERE id_usuario = new.id_usuario);" +
                            "END" ;
    String borrarUsuarios = "DROP TABLE Usuarios";

    public UsuariosOpenHelper(@Nullable Context context, @Nullable String name, @Nullable SQLiteDatabase.CursorFactory factory, int version) {
        super(context, name, factory, version);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        db.execSQL(crearUsuarios);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL(crearMensajes);
        db.execSQL(crearUsuarios);
        db.execSQL(crearTrigger);;
    }
}
