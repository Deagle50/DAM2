package com.example.repaso1;

import java.util.ArrayList;

public class Alumno {
    private int nExpediente;//representa el número de cuenta.
    private String Nombre;
    private String Apellido;
    private ArrayList<Falta> Faltas;

    public Alumno(int ne,String nom, String ape)
    {this.Nombre=nom;
        this.Apellido=ape;
        this.nExpediente=ne;
    }

    public int getnExpediente() {
        return nExpediente;
    }

    public String getNombre() {
        return Nombre;
    }

    public String getApellido() {
        return Apellido;
    }

    public void registrarFalta(int dia, int mes)
    {
        boolean encontrado;
        
        for(Faltas:ContadorFalta){

        }
    }
    public ArrayList<ContadorFalta> getFaltas()//Devuelve el array
    {
        return ArrayList<ContadorFalta> Faltas;
    }

}
