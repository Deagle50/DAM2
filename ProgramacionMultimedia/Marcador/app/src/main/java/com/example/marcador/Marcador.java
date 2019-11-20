package com.example.marcador;

import android.graphics.Canvas;
import java.util.ArrayList;

public class Marcador {
    private String estado;
    private String solucion;
    private ArrayList<Character> letras;
    private int fallos;

    public String getEstado() {
        return estado;
    }

    public void setSolucion(String solucion) {
        //Establecer solución e inicialzar el estado
        this.solucion = solucion;
    }

    public String getSolucion() {
        return solucion;
    }

    public boolean comprobar(char c){
        //Actulaliza el estado, buscando las ocurrencias del carácter c en la solución

        //devuelve true o false dependiendo de si hemos encontrado ocurrencias
        return true;
    }

    public void contarFallo(){
        //sumar 1 a fallos
        fallos+=1;
    }

    public void draw(Canvas canvas){
        //dibujar estado, dibujar marcador

    }
}
