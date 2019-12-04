package com.example.carreragatos;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.view.SurfaceHolder;
import android.view.SurfaceView;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.Random;

public class VistaDibujo extends SurfaceView implements Runnable{
    public int nGatos=8;
    ArrayList<ObjetoAnimado> coleccion = new ArrayList<ObjetoAnimado>();


    Thread hiloDibujo;
    volatile Boolean running = false;
    SurfaceHolder holder;
    /*int rojo = 255;
    int verde = 0;
    int azul = 0;
    int []colores={0, 0, 0};*/
    public Fondo pista;
    Canvas canvas;
    ObjetoAnimado gato;

    public VistaDibujo(Context context) {
        super(context);
        holder = getHolder();
        pista = new Fondo("pista.jpg");
        pista.inicializar(context.getAssets());
        int d = (int)(ObjetoAnimado.altoFil*0.75f)+25;
        for(int i=0;i<nGatos;i++)
        {

            gato= new ObjetoAnimado(0, 26+i*d/2, "gato.png", 60+10*i);
            coleccion.add(gato);
            gato.inicializar(context.getAssets());
        }

    }

    @Override
    public void run() {
        /*rojo=255;
        verde=255;
        azul=0;*/
        long actual = System.currentTimeMillis();
        ArrayList<String> ganadores = new ArrayList<String>();
        while(running)
        {

            if(System.currentTimeMillis()-actual>=80)
            {
                actual = System.currentTimeMillis();
                for(ObjetoAnimado gato:coleccion) {
                    gato.nextFrame();
                }
                //gato.nextFrame();
      }
            /*int i=getRandomNumberInRange(0,2);
            colores[i]=colores[i]+50;
            colores[i]=colores[i]%256;
            rojo=rojo%256;
            verde=verde%256;
            azul=azul%256;*/
            if(!holder.getSurface().isValid())
            {
                continue;
            }

            Random x = new Random(System.currentTimeMillis());
            for(ObjetoAnimado ga:coleccion)
            {
                //Cuánto avanzar
                ga.avanzar(x.nextInt(10));
            }
            Canvas c =holder.lockCanvas();
            drawSurface(c);
            holder.unlockCanvasAndPost(c);


            for(ObjetoAnimado gat:coleccion)
            {
                if(gat.fin())
                    ganadores.add(String.valueOf(coleccion.indexOf(gato)));
            }
            if (ganadores.size()!=0){
                running=false;
            }
        }


        String mensaje=getNombres(ganadores);

        while(!holder.getSurface().isValid()){

        }
        Canvas c = holder.lockCanvas();
        Paint p = new Paint();
        p.setTextSize(100);
        p.setColor(Color.BLUE);
        c.drawText(mensaje, 500, 500, p);
        holder.unlockCanvasAndPost(c);
    }
    private String getNombres(ArrayList<String> dorsales)
    {
        int i;
        String mensaje = "Ganador(es): ";
        for(i = 0; i < dorsales.size()-1; i++)
            mensaje += dorsales.get(i) + ", ";
        mensaje += dorsales.get(i);
        return mensaje;
    }

    private void drawSurface(Canvas canvas)
    {

        pista.draw(canvas);
        for(ObjetoAnimado gat:coleccion)
        {gat.draw(canvas);}
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



   /* private static int getRandomNumberInRange(int min, int max) {

        if (min >= max) {
            throw new IllegalArgumentException("max must be greater than min");
        }

        Random r = new Random();
        return r.nextInt((max - min) + 1) + min;
    }*/
}
