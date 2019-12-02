package com.example.carreragatos;

import android.content.Context;
import android.content.res.AssetManager;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Canvas;
import android.graphics.Rect;

import java.io.InputStream;

public class ObjetoAnimado {
    public static final int nFotogramas = 8;
    public static final int columnas = 2;
    public static final int filas = 4;
    public static final int anchoCol = 250;
    public static final int altoFil = 65;
    public static final int frameTime  = 80;

    int frameActual = 0;
    String fileName;
    private int posX, posY;
    Bitmap spriteSheet;

    public ObjetoAnimado(int posX, int posY, String file) {
        this.posX = posX;
        this.posY = posY;
        this.fileName = file;
    }

    public void inicializar(AssetManager asm)
    {
        try{
            InputStream is = asm.open(fileName);
            spriteSheet = BitmapFactory.decodeStream(is);
        }
        catch(Exception ex){
            ex.printStackTrace();
        }
    }

    public void avanzar(int n){
        posX+=n;

    }

    public void nextFrame()
    {
        frameActual = (frameActual<nFotogramas-1)?frameActual+1:0;
    }

    public void draw(Canvas c)
    {
        int x, y;
        y=altoFil+frameActual/columnas;
        x=anchoCol*frameActual%columnas;
        Rect origen = new Rect();
        Rect destino = new Rect(posX, posY, posX+20, posY+65);
        c.drawBitmap(spriteSheet, origen, destino, null);
    }
}
