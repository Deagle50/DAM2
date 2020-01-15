package com.example.repaso1;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class NuevoActivity extends AppCompatActivity
implements View.OnClickListener {
    Button btnNuevo,btnRegistrar;
    EditText txtNexp,txtNombre,txtApellido,txtDia,txtMes;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_nuevo);
        txtNombre = findViewById(R.id.txtNombre);
        txtApellido = findViewById(R.id.txtApellido);
        txtNexp = findViewById(R.id.txtNexp);
        txtDia = findViewById(R.id.txtDia);
        txtMes = findViewById(R.id.txtMes);
        btnNuevo = findViewById(R.id.btnNuevo);
        btnNuevo.setOnClickListener(this);
        btnRegistrar = findViewById(R.id.btnRegistrar);
        btnRegistrar.setOnClickListener(this);
    }

        @Override
        public void onClick(View v) {
            if (v==btnNuevo)
            {   int ne=Integer.parseInt(txtNexp.getText().toString());
                MainActivity.AlumnoActual=new Alumno(ne,txtNombre.getText().toString(),
                                                    txtApellido.getText().toString());
            }
            else
            {   int d,m;
                d=Integer.parseInt(txtDia.getText().toString());
                m=Integer.parseInt(txtMes.getText().toString());

                Falta f=new Falta(d,m);
                MainActivity.AlumnoActual.registrarFalta(d,m);
            }
        }
    }

