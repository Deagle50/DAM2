package com.example.apptemperaturas;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {
    boolean status=false;//De F a C
    Button btnConvertir;
    EditText txtFahren;
    EditText txtCenti;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        btnConvertir=findViewById(R.id.btnConvertir);
        txtFahren =findViewById(R.id.txtFahren);
        txtCenti=findViewById(R.id.txtCenti);
    }


    @Override
    public void onClick(View v) {
        float cant;
        if (!status)
        {
            cant = Float.parseFloat(txtFahren.getText().toString());
            cant=(cant-32)*5/9;
            txtCenti.setText(((Float)cant).toString());
        }
        else{
            cant=Float.parseFloat(txtCenti.getText().toString());
            cant=cant*9/5+32;
            txtFahren.setText(((Float)cant).toString());
        }

    }
}
