package com.deagle50.coctelpedia;

public class Coctel {
    private int id;
    private String nombre;
    private String urlFoto;
    private Float graduacion, precioC, precioB;
    private String elaboracion, descripcion;

    public Coctel(int id, String nombre, String urlFoto, Float graduacion, Float precioC, Float precioB, String elaboracion, String descripcion) {
        this.id = id;
        this.nombre = nombre;
        this.urlFoto = urlFoto;
        this.graduacion = graduacion;
        this.precioC = precioC;
        this.precioB = precioB;
        this.elaboracion = elaboracion;
        this.descripcion = descripcion;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getUrlFoto() {
        return urlFoto;
    }

    public void setUrlFoto(String urlFoto) {
        this.urlFoto = urlFoto;
    }

    public Float getGraduacion() {
        return graduacion;
    }

    public void setGraduacion(Float graduacion) {
        this.graduacion = graduacion;
    }

    public Float getPrecioC() {
        return precioC;
    }

    public void setPrecioC(Float precioC) {
        this.precioC = precioC;
    }

    public Float getPrecioB() {
        return precioB;
    }

    public void setPrecioB(Float precioB) {
        this.precioB = precioB;
    }

    public String getElaboracion() {
        return elaboracion;
    }

    public void setElaboracion(String elaboracion) {
        this.elaboracion = elaboracion;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }
}
