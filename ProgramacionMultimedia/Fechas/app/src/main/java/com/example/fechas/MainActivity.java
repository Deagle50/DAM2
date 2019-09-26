package com.example.fechas;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity implements View.OnClickListener{
    String []meses;
    int []dias;
    EditText txtDia, txtMes, txtAno;
    TextView lblSalida;
    Button btnComprobar;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        meses=getResources().getStringArray(R.array.meses);
        dias=getResources().getIntArray(R.array.dias);
        txtAno=findViewById(R.id.txtAno);
        txtMes=findViewById(R.id.txtMes);
        txtDia=findViewById(R.id.txtDia);
        btnComprobar=findViewById(R.id.btnComprobar);
        btnComprobar.setOnClickListener(this);
    }


    @Override
    public void onClick(View v){
        int d, m, a;
        boolean correcto=true;
        d=Integer.parseInt(txtDia.getText().toString());
        m=Integer.parseInt(txtMes.getText().toString());
        a=Integer.parseInt(txtAno.getText().toString());
        if(m<1||m>12)
            correcto=false;
        else
            if(m==2)
                if(a%4==0&&a%100!=0||a%400==0)
                    if(d>29)correcto=false;
                else
                    if(d>28)correcto=false;
                    else if(d>dias[m-1])
                        correcto=false;
        if(correcto)
            lblSalida.setText(String.format("%d de %s de %d", d, meses[m-1],a));
        else
            lblSalida.setText("La fecha es incorrecta");
    }
}
