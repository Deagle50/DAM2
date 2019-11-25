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
    private int fallos;    //Cabeza,brazoder,brazoiz,cuerpo,pieder,pieiz
    private Rect []coordsX={
            new Rect(600,175,700,275),
            new Rect(550,280,600,380),
            new Rect(600,280,750,380),
            new Rect(600,280,700,380),
            new Rect(600,390,650,490),
            new Rect(655,390,705,490)
            };
    static int j;
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
        //canvas.drawText(getEstado(), 10, 10, null);
        dibujarMarcador(canvas);
    }

    private void dibujarMarcador(Canvas canvas)
    {

        try {
        for (int i = 0; i < fallos&&j<coordsX.length; i++, j++) {

            InputStream is = asm.open(archivos[i]);
            Bitmap bmp = BitmapFactory.decodeStream(is);
            //Establecer coordenadas de los rectángulos
            canvas.drawBitmap(bmp, coordsX[j] , new Rect(420,0,1080,1080),null);
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
