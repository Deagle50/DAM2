package com.example.repaso1;

import java.util.ArrayList;

public class Alumno {
    private int nExpediente;//representa el número de cuenta.
    private String Nombre;
    private String Apellido;
    private ArrayList<Falta> Faltas=new ArrayList<Falta>();

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

        for(Falta f:Faltas)
            if(f.getDia()==dia&&f.getMes()==mes)
            {
                return;
            }
            Faltas.add(new Falta(dia, mes));
    }

    public ArrayList<ContadorFalta> getFaltas()
    {
        ArrayList<ContadorFalta> resultado = new ArrayList<ContadorFalta>();
        int []contaux=new int[12];

        for(Falta f:Faltas)
        {
            //Suma uno en el número del mes
            contaux[f.getMes()-1]++;
        }

        for(int i=0;i<contaux.length;i++)
        {
            resultado.add(new ContadorFalta(i+1, contaux[i]));
        }
        return resultado;

    }

}
