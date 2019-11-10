package com.example.repaso2;

public class AcumuladoVentas {
    int mes;
    float total;

    public AcumuladoVentas(int mes, float total) {
        this.mes = mes;
        this.total = total;
    }

    public int getMes() {
        return mes;
    }

    public float getTotal() {
        return total;
    }
}
