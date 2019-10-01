package com.example.traduccion;

public class Entrada {
    public Entrada(String palabra, String traduccion) {
        this.palabra = palabra;
        this.traduccion=traduccion;
    }
    String traduccion;
    String palabra;

    public String getPalabra() {
        return palabra;
    }

    public void setPalabra(String palabra) {
        this.palabra = palabra;
    }

    public String getTraduccion() {
        return traduccion;
    }

    public void setTraduccion(String traduccion) {
        this.traduccion = traduccion;
    }
}
