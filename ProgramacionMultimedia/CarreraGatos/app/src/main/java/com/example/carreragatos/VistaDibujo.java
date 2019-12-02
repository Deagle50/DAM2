package com.example.carreragatos;

import android.content.Context;
import android.graphics.Canvas;
import android.view.SurfaceHolder;
import android.view.SurfaceView;

import java.util.Random;

public class VistaDibujo extends SurfaceView implements Runnable{
    Thread hiloDibujo;
    volatile Boolean running = false;
    SurfaceHolder holder;
    int rojo = 255;
    int verde = 0;
    int azul = 0;
    int []colores={0, 0, 0};
    public Fondo pista;
    Canvas canvas;
    ObjetoAnimado gato;
    public VistaDibujo(Context context) {
        super(context);
        holder = getHolder();
        pista = new Fondo("pista.jpg");
        pista.inicializar(context.getAssets());
        gato= new ObjetoAnimado(0, 25, "gato.png");
        gato.inicializar(context.getAssets());
    }

    @Override
    public void run() {
        rojo=255;
        verde=255;
        azul=0;
        long actual = System.currentTimeMillis();
        while(running)
        {
            if(System.currentTimeMillis()-actual==80)
            {
                actual = System.currentTimeMillis();
                gato.nextFrame();
      }
            int i=getRandomNumberInRange(0,2);
            colores[i]=colores[i]+50;
            colores[i]=colores[i]%256;
            rojo=rojo%256;
            verde=verde%256;
            azul=azul%256;
            if(!holder.getSurface().isValid())
            {
                continue;
            }
            canvas = holder.lockCanvas();
            drawSurface(canvas);
            holder.unlockCanvasAndPost(canvas);
        }
    }

    private void drawSurface(Canvas canvas)
    {

        pista.draw(canvas);
        //canvas.drawRGB(colores[0],colores[1],colores[2]);//FIESTAAAAA COCAAAAAA}
    }

    public void reanudar()
    {
        hiloDibujo = new Thread(this);
        running = true;
        hiloDibujo.start();
    }

    public void pausar()
    {
        running = false;
        while(true)
        {
            try
            {
                hiloDibujo.join();
                break;
            }
            catch(Exception ex)
            {
                //retry
            }
        }
        hiloDibujo = null;
    }

    private static int getRandomNumberInRange(int min, int max) {

        if (min >= max) {
            throw new IllegalArgumentException("max must be greater than min");
        }

        Random r = new Random();
        return r.nextInt((max - min) + 1) + min;
    }
}
