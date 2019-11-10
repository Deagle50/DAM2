package com.example.repaso1;

import java.lang.reflect.Array;
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
        Falta a = new Falta(dia,mes);
        boolean existe = false;

        for (int i = 0; i < Faltas.size(); i++) {
            if(Faltas.get(i).dia == dia && Faltas.get(i).mes == mes){
                existe = true;
                break;
            }
        }

        if(!existe){
            Faltas.add(a);
        }
    }
    public ArrayList<ContadorFalta> getFaltas()//Devuelve el array
    {
        ArrayList<ContadorFalta> ContadorFaltas = new ArrayList<>();

        ContadorFalta a = new ContadorFalta(0,0);

        for (int i = 1; i < 13; i++) {
            a.mes = i;
            for (int j = 0; j < Faltas.size(); j++) {
                if (Faltas.get(j).mes == i){
                    a.contador ++;
                }
            }
            ContadorFaltas.add(a);
        }
        return ContadorFaltas;
    }

}
