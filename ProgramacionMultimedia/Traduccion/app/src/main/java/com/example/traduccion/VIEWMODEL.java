package com.example.traduccion;

import java.util.ArrayList;

public class VIEWMODEL {
    String []palabras;
    String []significados;

    public VIEWMODEL(String[] palabras, String[] significados) {
        for(int i=0;i<palabra.length;i++)
        {
            lista.add(new Entrada(palabras[i], significados[i]));
        }
    }

    private ArrayList<Entrada> lista;
    private Entrada resultado;

    private String buscar(String []palabra){
        for (int i = 0; i < lista.size(); i++) {
            if(lista.get(i).getPalabra().equals(palabra))
                return lista.get(i).getTraduccion();

        }
        return null;
    }
}
