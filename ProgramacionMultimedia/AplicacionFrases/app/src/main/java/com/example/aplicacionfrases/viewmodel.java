package com.example.aplicacionfrases;

import android.graphics.drawable.AnimationDrawable;

import androidx.annotation.NonNull;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Random;

public class viewmodel {
    AnimationDrawable animacion;
    private ArrayList<String> lista=new ArrayList<>();
    private Random random = new Random();
    private String chiste;

    public viewmodel(String[] chistes, AnimationDrawable anim){
        animacion=anim;
        lista.addAll(Arrays.asList(chistes));
    }


    public void chisteAlazar() {
        chiste = lista.get(random.nextInt(lista.size()));
    }

    public String getChiste(){
        return chiste;
    }
}
