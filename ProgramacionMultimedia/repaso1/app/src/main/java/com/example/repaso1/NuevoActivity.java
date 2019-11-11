package com.example.repaso1;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class NuevoActivity extends AppCompatActivity implements View.OnClickListener {
    Button btnNuevo, btnRegistrar;
    EditText txtNExpediente, txtNombre, txtApellido, txtDia, txtMes;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_nuevo);
        txtNombre=findViewById(R.id.txtNombre);
        txtNExpediente=findViewById(R.id.txtNExpediente);
        txtDia=findViewById(R.id.txtDia);
        txtMes=findViewById(R.id.txtMes);
        txtApellido=findViewById(R.id.txtApellido);
        btnNuevo=findViewById(R.id.btnNuevo);
        btnRegistrar=findViewById(R.id.btnRegistrar);
        btnNuevo.setOnClickListener(this);
        btnRegistrar.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {

    }
}
