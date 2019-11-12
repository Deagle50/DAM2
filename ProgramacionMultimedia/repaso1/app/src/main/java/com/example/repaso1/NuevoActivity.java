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
        txtApellido=findViewById(R.id.txtApellido);
        txtNExpediente=findViewById(R.id.txtNExpediente);

        txtDia=findViewById(R.id.txtDia);
        txtMes=findViewById(R.id.txtMes);

        btnNuevo=findViewById(R.id.btnNuevo);
        btnNuevo.setOnClickListener(this);
        btnRegistrar=findViewById(R.id.btnRegistrar);
        btnRegistrar.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {
        if(v==btnNuevo)
        {
            int ne = Integer.parseInt(txtNExpediente.getText().toString());
            MainActivity.AlumnoActual= new Alumno(ne, txtNombre.getText().toString(),
                    txtApellido.getText().toString());

        }
        else
        {
            int d = Integer.parseInt(txtDia.getText().toString());
            int m = Integer.parseInt(txtMes.getText().toString());
            Falta f = new Falta(d, m);
            MainActivity.AlumnoActual.registrarFalta(d, m);

        }
    }
}
