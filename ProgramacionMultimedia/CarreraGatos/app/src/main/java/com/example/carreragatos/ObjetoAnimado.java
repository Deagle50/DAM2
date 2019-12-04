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
    public static final int anchoCol = 500;
    public static final int altoFil = 260;
    private int frameTime;

    int frameActual;
    String fileName;
    private int posX;

    private int posY;
    Bitmap spriteSheet;

    public ObjetoAnimado(int posX, int posY, String file, int v) {
        this.posX = posX;
        this.posY = posY;
        this.fileName = file;
        frameActual=0;
        frameTime=v;
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
        Rect origen = new Rect(x, y, x+anchoCol, y+altoFil);
        Rect destino = new Rect(posX, posY, posX+anchoCol, posY+altoFil);
        c.drawBitmap(spriteSheet, origen, destino, null);
    }

    public int getFrameTime(){
        return frameTime;
    }

    public boolean fin(){
        if(posX>=1718)
        {return true;}

        return false;
    }
}
