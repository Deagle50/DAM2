package com.example.repaso2;

public class Venta {
    int mes;
    float importe;

    public int getMes() {
        return mes;
    }

    public float getImporte() {
        return importe;
    }

    public Venta(int mes, float importe) {
        this.mes = mes;
        this.importe = importe;
    }
}
