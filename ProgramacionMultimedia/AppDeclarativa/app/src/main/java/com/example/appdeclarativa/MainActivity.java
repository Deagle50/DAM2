package com.example.appdeclarativa;

import android.graphics.Typeface;
//import android.icu.lang.UCharacter;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

public class MainActivity extends AppCompatActivity implements View.OnClickListener{

    int contador=0;

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        LinearLayout ll;
        ll=new LinearLayout(this);
        ll.setOrientation(LinearLayout.VERTICAL);
        TextView tv=new TextView(this);
        tv.setText("Botón para pulsar");
        tv.setTypeface(Typeface.SANS_SERIF, Typeface.NORMAL);
        tv.setTextSize(12);
        Button btn=new Button(this);
        btn.setText("Pulsa el botón");
        btn.setOnClickListener(this);
        ll.addView(tv);
        ll.addView(btn);
        setContentView(ll);



    }

    @Override
    public void onClick(View v) {
        contador++;
        Toast.makeText(this,((Integer) contador).toString(),Toast.LENGTH_LONG).show();
    }
}
