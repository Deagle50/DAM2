package com.example.spinner3;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Spinner;

public class MainActivity extends AppCompatActivity implements AdapterView.OnItemSelectedListener {
    String []meses;
    String []estaciones;
    Spinner spMeses,spEstaciones;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        meses=getResources().getStringArray(R.array.meses);
        estaciones=getResources().getStringArray(R.array.Estaciones);
        spMeses=findViewById(R.id.spMeses);
        spEstaciones=findViewById(R.id.spEstaciones);
        spMeses.setAdapter(new ArrayAdapter<String>(this,android.R.layout.simple_spinner_item,meses));
        spEstaciones.setAdapter(new ArrayAdapter<String>(this,android.R.layout.simple_spinner_item,estaciones));
        spEstaciones.setSelection(3);
        spMeses.setOnItemSelectedListener(this);
    }


    @Override
    public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {
        if(position==11||position==0||position==1)
        {
            spEstaciones.setSelection(3);
        }
        else if(position<5)
        {
            spEstaciones.setSelection(0);
        }
        else if(position<8)
        {
            spEstaciones.setSelection(1);
        }
        else if(position<11)
        {
            spEstaciones.setSelection(2);
        }
    }

    @Override
    public void onNothingSelected(AdapterView<?> parent) {

    }
}
