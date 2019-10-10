package com.example.ejemplodirecciones;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.ListView;

public class TodasActivity extends AppCompatActivity {
    ListView lv;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_todas);
        lv=findViewById(R.id.lvTodos);
        DireccionesArrayAdapter da=new DireccionesArrayAdapter(this, R.layout.plantila_fila,
                MainActivity.direcciones);
        lv.setAdapter(da);
    }
}
