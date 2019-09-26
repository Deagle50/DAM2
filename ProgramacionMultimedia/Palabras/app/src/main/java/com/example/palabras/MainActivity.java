package com.example.palabras;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

public class MainActivity extends AppCompatActivity implements View.OnClickListener{
    String []palabras;
    int pos=0;
    EditText txtPalabra;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        palabras=getResources().getStringArray(R.array.palabras);
        txtPalabra=findViewById(R.id.txtPalabra);
    }


}
