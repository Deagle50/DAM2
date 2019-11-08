package com.example.versionesandroidrecycler;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.GridLayoutManager;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.content.res.TypedArray;
import android.os.Bundle;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {
    ArrayList<AndroidVersion> Objetos=new ArrayList<AndroidVersion>();
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        llenarColeccion(Objetos);
        RecyclerVersionAdapter rva=new RecyclerVersionAdapter(this,R.layout.recyclerviewline,Objetos);
        RecyclerView rv=findViewById(R.id.recycler);
        rv.setLayoutManager(new LinearLayoutManager(this));
        rv.setAdapter(rva);
    }

    void llenarColeccion(ArrayList <AndroidVersion> col)
    {
        String[] nombres;
        String[] versiones;
        int[] periodos;
        int[] api;
        TypedArray id;
        nombres=getResources().getStringArray(R.array.nombres);
        versiones=getResources().getStringArray(R.array.versiones);
        periodos=getResources().getIntArray(R.array.periodos);
        api=getResources().getIntArray(R.array.apis);
        id=getResources().obtainTypedArray(R.array.drawableIds);

        for (int i=0;i<periodos.length;i++)
        {
            AndroidVersion v=new AndroidVersion(nombres[i],versiones[i],api[i],periodos[i],id.getResourceId(i,-1));
            col.add(v);
        }
    }
}
