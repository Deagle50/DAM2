package com.example.repaso1;

import android.content.Context;
import android.graphics.Color;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.LinearLayout;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import org.w3c.dom.Text;

import java.util.ArrayList;

public class FaltasAdapter extends ArrayAdapter {
    ArrayList<ContadorFalta> lista;
    ConsultarActivity activity;
    int id;

    public FaltasAdapter(@NonNull Context context, int resource, @NonNull ArrayList<ContadorFalta> objects) {
        super(context, resource, objects);
        lista = lista;
        activity = (ConsultarActivity)context;
        id = resource;
    }

    @NonNull
    @Override
    public View getView(int position, @Nullable View convertView, @NonNull ViewGroup parent)
    {
        LinearLayout v = (LinearLayout) activity.getLayoutInflater().inflate(id, parent, false);
        TextView txtMes, txtFaltas;

        txtFaltas = v.findViewById(R.id.txtFaltas);
        txtMes = v.findViewById(R.id.txtMes);

        txtMes.setText(String.valueOf(lista.get(position).getMes()));
        txtFaltas.setText(String.valueOf(lista.get(position).getCont()));

        if(position%2==0)
            v.setBackgroundColor(Color.CYAN);

        return v;
    }

    @Override
    public int getCount(){
        return lista.size();
    }
}
