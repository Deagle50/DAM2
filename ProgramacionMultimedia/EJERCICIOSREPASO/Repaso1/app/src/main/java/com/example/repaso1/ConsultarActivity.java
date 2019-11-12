package com.example.repaso1;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.ListView;

public class ConsultarActivity extends AppCompatActivity {
    ListView lv;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_consultar);
        lv=findViewById(R.id.lvLista);
        FaltasAdapter fa=new FaltasAdapter(this,R.layout.linealayout   ,MainActivity.AlumnoActual.getFaltas());
        lv.setAdapter(fa);

    }
}
