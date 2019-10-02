package com.example.traduccion;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity implements View.OnClickListener{

    String []s;
    String []t;
    Button btnTraducir;
    TextView txtPalabra;
    TextView txtTraduccion;
    VIEWMODEL v = new VIEWMODEL(s,t);

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        btnTraducir=findViewById(R.id.btnTraducir);
        txtPalabra=findViewById(R.id.txtPalabra);
        txtTraduccion=findViewById(R.id.txtTraduccion);
        VIEWMODEL(s, t);
    }




    @Override
    public void onClick(View v){
        s=
    }
}
