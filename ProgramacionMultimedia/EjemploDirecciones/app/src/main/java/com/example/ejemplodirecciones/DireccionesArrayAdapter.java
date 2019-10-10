package com.example.ejemplodirecciones;

import android.content.Context;
import android.graphics.Color;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import java.util.ArrayList;
import java.util.List;

public class DireccionesArrayAdapter extends ArrayAdapter {
    AppCompatActivity activity;
    int resourceID;
    ArrayList<Direccion> objetos;
    public DireccionesArrayAdapter(@NonNull Context context, int resource, @NonNull List objects) {
        super(context, resource, objects);
        activity=(AppCompatActivity)context;
        resourceID=resource;
        objetos=(ArrayList<Direccion>)objects;
    }

    @NonNull
    @Override
    public View getView(int position, @Nullable View convertView, @NonNull ViewGroup parent) {
        View layout;
        layout=activity.getLayoutInflater().inflate(R.layout.plantila_fila, null);
        TextView txtNombre, txtApellido, txtTelefono;
        txtNombre=layout.findViewById(R.id.txtNombre);
        txtApellido=layout.findViewById(R.id.txtApellido);
        txtTelefono=layout.findViewById(R.id.txtTelefono);
        txtNombre.setText(objetos.get(position).getNombre());
        txtApellido.setText(objetos.get(position).getApellido());
        txtTelefono.setText(objetos.get(position).getTelefono());
        if(position%2==0)
        {
            layout.setBackgroundColor(Color.LTGRAY);
        }
        return layout;
    }

    @Nullable
    @Override
    public Object getItem(int position) {
        return objetos.get(position);
    }

    @Override
    public int getCount() {

        return objetos.size();
    }
}
