package com.example.carreragatos;

import android.content.res.AssetManager;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Canvas;
import android.graphics.Rect;

import java.io.InputStream;

public class Fondo {
    Bitmap bmpFondo;
    String filename;

    Fondo(String file)
    {
        this.filename = file;
    }

    public void inicializar(AssetManager asm)
    {
        try{
            InputStream is = asm.open(filename);
            bmpFondo = BitmapFactory.decodeStream(is);
        }
        catch(Exception ex)
        {
            ex.printStackTrace();
        }
    }

    public void draw(Canvas c)
    {
        c.drawBitmap(bmpFondo, null, new Rect(0,0,2160, 1080), null);
    }
}
