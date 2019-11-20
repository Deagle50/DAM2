package com.example.marcador;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.LinearLayout;

public class MainActivity extends AppCompatActivity  implements View.OnClickListener{
    LinearLayout lv;
    VistaJuego vista;
    String []palabras;
    EditText txtLetra;
    Button btnMostrar;
    @Override
    protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        lv = findViewById(R.id.linearLayout);
        vista = new VistaJuego(this);
        lv.addView(vista);
        palabras=getResources().getStringArray(R.array.palabras);
        btnMostrar=findViewById(R.id.btnMostrar);
        btnMostrar.setOnClickListener(this);
        txtLetra=findViewById(R.id.txtLetra);

    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.menu, menu);
        return super.onCreateOptionsMenu(menu);
    }

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        if(item.getItemId()==R.id.mnuNuevo)
        {

        }
        else
            finish();
        return super.onOptionsItemSelected(item);
    }


    @Override
    public void onClick(View v) {
        if(v==btnMostrar)
        {

        }
    }
}
