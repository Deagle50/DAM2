package com.example.spinner2;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;

import java.lang.reflect.Array;
import java.util.ArrayList;

public class MainActivity extends AppCompatActivity implements View.OnClickListener{
    Spinner sp;
    Button btnAgregar;
    EditText txtNombre;
    ArrayList<String> nombres=new ArrayList<String>();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        btnAgregar=findViewById(R.id.button);
        sp=findViewById(R.id.spinner);
        txtNombre=findViewById(R.id.editText);
        sp.setAdapter(new ArrayAdapter<String>(this, R.layout.support_simple_spinner_dropdown_item, nombres));
        btnAgregar.setBackgroundColor(121212);
    }

    @Override
    public void onClick(View v) {
        nombres.add(txtNombre.getText().toString());
        txtNombre.setText("");
    }
}
