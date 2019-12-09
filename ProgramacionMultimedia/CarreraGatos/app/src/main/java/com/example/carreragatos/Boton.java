package com.example.carreragatos;

import android.content.res.AssetManager;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Canvas;
import android.graphics.Rect;

import java.io.InputStream;

public class Boton {
    Bitmap bmpBoton;
    String fileName;
    int x=500, y=600;
    Boton(String file){
        this.fileName=file;
    }

    public void inicializar(AssetManager asm){
        InputStream is = null;
        try{
            is = asm.open(fileName);
            bmpBoton = BitmapFactory.decodeStream(is);
        }
        catch(Exception ex)
        {
            ex.printStackTrace();
        }
    }

    public void draw(Canvas c, boolean status)
    {
        if (status)
        c.drawBitmap(bmpBoton, null, new Rect(x,y,300, 270), null);
    }
}
