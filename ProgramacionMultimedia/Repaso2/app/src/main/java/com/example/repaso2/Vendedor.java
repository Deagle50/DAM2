package com.example.repaso2;

import java.util.ArrayList;

public class Vendedor {
    private int codigo;
    private String nombre;
    private String apellido;
    private ArrayList<Venta> Ventas;

    public Vendedor(int codigo, String nombre, String apellido) {
        this.codigo = codigo;
        this.nombre = nombre;
        this.apellido = apellido;

    }

    public int getCodigo() {
        return codigo;
    }

    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellido() {
        return apellido;
    }

    public void setApellido(String apellido) {
        this.apellido = apellido;
    }

    public void registrarVenta(int m, float i)
    {
        Venta v = new Venta(m, i);
        Ventas.add(v);
    }

    public ArrayList<AcumuladoVentas> getVentas() {
        ArrayList<AcumuladoVentas> array = new ArrayList</*AcumuladoVentas*/>();


        float suma = 0;
        for (int i = 1; i < 12; i++) {
            AcumuladoVentas sumaventas = new AcumuladoVentas(0,0);
            sumaventas.mes=i;
            for (int j = 1; j < 31; j++) {
                if(Ventas.get(j).mes==i)
                    sumaventas.total+=Ventas.get(j).importe;
            }
            array.add(sumaventas);
        }
        return array;
    }
}
