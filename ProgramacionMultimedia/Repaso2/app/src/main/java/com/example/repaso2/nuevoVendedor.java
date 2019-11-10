package com.example.repaso2;

import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

public class nuevoVendedor extends AppCompatActivity implements View.OnClickListener{
    TextView txtCod= findViewById(R.id.txtCodigo);
    TextView txtNom= findViewById(R.id.txtNombre);
    TextView txtAp=findViewById(R.id.txtApellido);
    TextView txtMes = findViewById(R.id.txtMes);
    TextView txtImporte=findViewById(R.id.txtImporte);
    int cod, mes;
    float importe;
    String nom, ap;
    public Vendedor VendedorActual;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.nuevovendedor);

    }


    @Override
    public void onClick(View v) {
        cod=Integer.parseInt(txtCod.getText().toString());
        nom=txtNom.getText().toString();
        ap=txtAp.getText().toString();
        Vendedor VendedorActual = new Vendedor(cod, nom, ap);
    }

    public void onClick2(){
        importe=Integer.parseInt(txtImporte.getText().toString());
        mes=Integer.parseInt(txtMes.getText().toString());
        VendedorActual.registrarVenta(mes, importe);
    }
}
