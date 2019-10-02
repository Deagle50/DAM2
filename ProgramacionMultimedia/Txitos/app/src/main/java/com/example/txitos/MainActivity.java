package com.example.txitos;

import androidx.appcompat.app.AppCompatActivity;

import android.graphics.drawable.AnimationDrawable;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;

public class MainActivity extends AppCompatActivity implements View.OnClickListener{

    Button btnStart;
    ImageView imgAnimacion;
    AnimationDrawable animacion;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        imgAnimacion=findViewById(R.id.imgAnimacion);
        animacion=(AnimationDrawable)imgAnimacion.getBackground();
        btnStart=findViewById(R.id.btnStart);
        btnStart.setOnClickListener(this);
    }

    @Override
    public void onClick(View v){
        btnStart=findViewById(R.id.btnStart);
        Button btn=(Button)v;
        if(btn.getText().toString().compareTo("START")==0)
        {
            animacion.start();
            btn.setText("STOP");
        }
        else{
            animacion.stop();
            btn.setText("START");
        }
    }
}
