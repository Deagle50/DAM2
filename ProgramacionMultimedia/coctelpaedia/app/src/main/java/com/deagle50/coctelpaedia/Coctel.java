package com.deagle50.coctelpaedia;

public class Coctel {
    //Coctel class, with each
    private int id;
    private String name;
    private int urlPhoto;
    private Float graduation, priceH, priceB;
    private String elaboration, description;
    private boolean vegetarian;
    private boolean vegan;
    private String type;

    public Coctel(String name, int urlPhoto, Float graduation, Float priceH, Float priceB, String elaboration, String description, boolean vegetarian, boolean vegan, String type) {
        this.name = name;
        this.urlPhoto = urlPhoto;
        this.graduation = graduation;
        this.priceH = priceH;
        this.priceB = priceB;
        this.elaboration = elaboration;
        this.description = description;
        this.vegetarian = vegetarian;
        this.vegan = vegan;
        this.type = type;
    }


    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public int getUrlPhoto() {
        return urlPhoto;
    }

    public Float getGraduation() {
        return graduation;
    }

    public Float getPriceH() {
        return priceH;
    }

    public Float getPriceB() {
        return priceB;
    }

    public String getElaboration() {
        return elaboration;
    }

    public String getDescription() {
        return description;
    }

    public boolean isVegetarian() {
        return vegetarian;
    }

    public boolean isVegan() {
        return vegan;
    }

    public String getType() {
        return type;
    }

}
