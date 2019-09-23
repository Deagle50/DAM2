package com.example.appsaludo;

import androidx.appcompat.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        btnSaludo=findViewById(R.id.btnSaludar);
        txtNombre=findViewById(R.id.txtNombre);
        btnSaludo.setOnClickListener(this);
    }

    @Override
    public void onClick(View v)
    {
        String pal=getResources().getString(R.string.app_saludo_p);
        Toast.makeText(this, String.format(pal,txtNombre.getText().toString()), Toast.LENGTH_LONG).show();
    }
}
