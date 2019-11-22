package com.example.marcador;

import android.content.Context;
import android.content.res.AssetManager;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Canvas;
import android.graphics.Rect;

import androidx.appcompat.app.AppCompatActivity;

import java.io.IOException;
import java.io.InputStream;
import java.util.ArrayList;

public class Marcador {
    private String estado;
    private String solucion;
    private ArrayList<Character> letras;
    private String []archivos;
    private int fallos;
    public AssetManager asm;

    //Constructor
    public Marcador(AssetManager asm) {
        this.asm = asm;

    }

    public void startMarcador(AppCompatActivity ca){
        archivos = ca.getResources().getStringArray(R.array.archivos);
    }

    public String getEstado() {
        return estado;
    }

    public void setSolucion(String solucion) {
        String aux="";
        //Establecer solución e inicializar el estado
        this.solucion = solucion;

        for (int i = 0; i < solucion.length(); i++) {
            aux+="_";
        }
        this.estado = aux;
    }

    public String getSolucion() {
        return solucion;
    }

    public boolean comprobar(char c){
        boolean respuesta=false;
        //Actualiza el estado, buscando las ocurrencias del carácter c en la solución


        //devuelve true o false dependiendo de si hemos encontrado ocurrencias
        for (int i = 0; i < solucion.length(); i++)
        {
            if(solucion.charAt(i)==c)
            {
                respuesta=true;
                StringBuilder sb = new StringBuilder(this.estado);
                sb.insert(i,c);
            }
        }
        return respuesta;
    }

    public void contarFallo()
    {
        //sumar 1 a fallos
        fallos+=1;
    }

    public void draw(Canvas canvas){
        //dibujar estado, dibujar marcador
        draw(canvas);
        dibujarMarcador(canvas);

    }

    private void dibujarMarcador(Canvas canvas)
    {
        try {
        for (int i = 0; i < fallos; i++) {

            InputStream is = asm.open(archivos[i]);
            Bitmap bmp = BitmapFactory.decodeStream(is);
            //Establecer coordenadas de los rectángulos
            canvas.drawBitmap(bmp, getCoordenadasOrigen() , getCoordenadasDestino(),null);
            }} catch (IOException e) {
                e.printStackTrace();
            }
        }

    private Rect getCoordenadasOrigen() {
        Rect r = new Rect();
        //Hacer función
        return null;
    }

    private Rect getCoordenadasDestino() {
        return null;
    }
}
