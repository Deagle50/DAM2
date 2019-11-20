package com.example.administrador.animacion;

import android.content.Context;
import android.content.res.AssetManager;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Canvas;
import android.graphics.Rect;

import java.io.IOException;
import java.io.InputStream;

/**
 * Created by Administrador on 28/10/2016.
 */

public class ObjetoAnimado {
    public final int nfilas=4;
    public final int ncolumnas=2;
    public final int picwidth=207;
    public final int picheight=160;
    public int speed=40;
    public int width,height;
    public int posX,posY;
    public int currentFrame;
    Bitmap imagen;
    public  ObjetoAnimado(Context con, String f, int w, int h, int x, int y)
    {
        AssetManager asm=con.getAssets();
        try {
            InputStream isr=asm.open(f);
            imagen= BitmapFactory.decodeStream(isr);
            width=w;
            height=h;
            posX=x;
            posY=y;
            currentFrame=0;
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    public void nextFrame()
    {
        currentFrame++;
        currentFrame=currentFrame%(nfilas*ncolumnas);
    }

    public void dibujar(Canvas c)
    {
        int ox,oy,dx=posX,dy=posY;
        int fila= currentFrame/ncolumnas;
        int col=currentFrame%ncolumnas;
        ox=col*picwidth;
        oy=fila*picheight;
        c.drawBitmap(imagen,new Rect(ox,oy,ox+picwidth,oy+picheight),
                     new Rect(dx,dy,dx+width,dy+height),null);
        /*try {
            Thread.sleep(speed);
        } catch (InterruptedException e) {
            e.printStackTrace();
        }*/
    }
}
