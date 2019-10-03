package com.example.aplicacionfrases;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.graphics.drawable.AnimationDrawable;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity implements View.OnClickListener{
    Button btnUrko;
    Button btnAcercaDe;
    TextView txtBocadillo;
    AnimationDrawable animacion;
    viewmodel viewmodel;

    int pos=0;



    @Override
    protected void onCreate(Bundle savedInstanceState) {

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        btnUrko=findViewById(R.id.btnUrko);
        btnAcercaDe=findViewById(R.id. btnAcercaDe);
        txtBocadillo=findViewById(R.id.txtBocadillo);
        btnUrko.setOnClickListener(this);
        btnAcercaDe.setOnClickListener((v)->{
            Intent intent = new Intent(MainActivity.this, AcercaDe.class);
            startActivity(intent);
        });
        animacion=(AnimationDrawable)btnUrko.getBackground();
        viewmodel=new viewmodel(getResources().getStringArray(R.array.chistes), animacion);
        animacion.setOneShot(true);

    }

    @Override
    public void onClick(View v) {

        animacion.setVisible(true,true);
        animacion.start();
        viewmodel.chisteAlazar();
        txtBocadillo.setText(viewmodel.getChiste());

    }
}
