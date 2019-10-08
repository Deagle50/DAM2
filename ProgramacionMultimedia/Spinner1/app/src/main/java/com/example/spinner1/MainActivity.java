package com.example.spinner1;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.Spinner;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {
    String []tabla;
    Spinner sp;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        tabla=getResources().getStringArray(R.array.dias);
        ArrayAdapter<String> adaptador=new ArrayAdapter<String>(this, R.layout.support_simple_spinner_dropdown_item, tabla);
        sp=findViewById(R.id.spinner);
        sp.setAdapter(adaptador);
        ArrayList<String> pal=arra  
    }
}
