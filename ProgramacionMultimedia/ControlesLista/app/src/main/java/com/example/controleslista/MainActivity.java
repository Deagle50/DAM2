package com.example.controleslista;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.RecyclerView;

import android.os.Bundle;
import android.widget.Spinner;

public class MainActivity extends AppCompatActivity {
RecyclerView rv;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        //Recuperamos el control Spinner
        rv=findViewById(R.id.);
        //Cargamos el array días a partir del recurso días.xml;
        String[] dias=getResources().getStringArray(R.array.dias);
        //Creamos el adaptador para relacionar los elementos del array con
        //los ítems de la lista.
        ArrayAdapter<String> adapter=new ArrayAdapter<String>(this,android.R.layout.simple_spinner_item,dias);
        sp.setAdapter(adapter);

    }
}
