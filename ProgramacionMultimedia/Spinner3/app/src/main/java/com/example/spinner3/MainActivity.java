package com.example.spinner3;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Spinner;

public class MainActivity extends AppCompatActivity implements AdapterView.OnItemSelectedListener {
    String[] meses;
    String[] estaciones;
    Spinner spnMeses;
    Spinner spnEstaciones;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        meses = getResources().getStringArray(R.array.meses);
        estaciones = getResources().getStringArray(R.array.estaciones);
        spnMeses = findViewById(R.id.spnMeses);
        spnEstaciones = findViewById(R.id.spnEstaciones);

        spnMeses.setAdapter(new ArrayAdapter<String>(this,
                android.R.layout.simple_spinner_item, meses));
        spnEstaciones.setAdapter(new ArrayAdapter<String>(this,
                android.R.layout.simple_spinner_item, estaciones));
        spnEstaciones.setSelection(3);
        spnMeses.setOnItemSelectedListener(this);
    }

    @Override
    public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {
        if(position==11||position==0||position==1)
        {
            spnEstaciones.setSelection(3);
        }
        else if (position<5)
        {
            spnEstaciones.setSelection(0);
        }
        else if(position<8)
        {
            spnEstaciones.setSelection(1);
        }
        else if(position<11)
        {
            spnEstaciones.setSelection(2);

        }
    }

    @Override
    public void onNothingSelected(AdapterView<?> parent) {

    }
}
