package com.example.repaso1;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.ListView;

public class ConsultarActivity extends AppCompatActivity {
    ListView LV;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_consultar);
        LV=findViewById(R.id.LV);

        FaltasAdapter fa = new FaltasAdapter(this, R.layout.linealayout,
                MainActivity.AlumnoActual.getFaltas());
        LV.setAdapter(fa);
    }
}
