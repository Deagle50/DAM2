package com.example.aplicacionfrases;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

import androidx.appcompat.app.AppCompatActivity;

public class AcercaDe extends AppCompatActivity implements View.OnClickListener{
    Button btnAtras;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.acercade);
        btnAtras=findViewById(R.id.btnAtras);
        btnAtras.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {
        Intent intent = new Intent(AcercaDe.this, MainActivity.class);
        startActivity(intent);
    }
}
