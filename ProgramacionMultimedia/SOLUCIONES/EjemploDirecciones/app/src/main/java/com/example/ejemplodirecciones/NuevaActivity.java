package com.example.ejemplodirecciones;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class NuevaActivity extends AppCompatActivity implements View.OnClickListener {
    EditText txtNombre,txtApellido,txtTelefono;
    Button btnAgregar;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_nueva);
        txtNombre=findViewById(R.id.txtNombre);
        txtApellido=findViewById(R.id.txtApellido);
        txtTelefono=findViewById(R.id.txtTelefono);
        btnAgregar=findViewById(R.id.btnAgregar);
        btnAgregar.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {
        Direccion nueva=new Direccion(txtNombre.getText().toString(),
                txtApellido.getText().toString(),txtTelefono.getText().toString());
        MainActivity.direcciones.add(nueva);
    }
}
