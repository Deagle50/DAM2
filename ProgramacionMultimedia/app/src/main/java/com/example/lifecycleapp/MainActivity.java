package com.example.lifecycleapp;

import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity implements View.OnClickListener{
    int pulsaciones=0;
    Button btnPulsador;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        btnPulsador=findViewById(R.id.btnPulsador);
        btnPulsador.setOnClickListener(this);
        if(savedInstanceState!=null && savedInstanceState.containsKey("KEY_NUMBER") )
        pulsaciones=savedInstanceState.getInt("KEY_NUMBER");
    }

    @Override
    public void onClick(View v){
        pulsaciones++;
        Toast.makeText(this, String.valueOf(pulsaciones), Toast.LENGTH_LONG).show();
    }

    @Override
    protected void onSaveInstanceState(Bundle outState) {
        outState.putInt("KEY_NUMBER", pulsaciones);
        super.onSaveInstanceState(outState);
    }
}
