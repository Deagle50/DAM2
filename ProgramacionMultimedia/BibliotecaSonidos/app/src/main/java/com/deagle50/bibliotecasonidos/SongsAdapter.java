package com.deagle50.bibliotecasonidos;

import android.database.Cursor;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

public class SongsAdapter extends RecyclerView.Adapter<SongsAdapter.CustomViewHolder> {
    Cursor cursor;
    int resource;

    class CustomViewHolder extends RecyclerView.ViewHolder {
        TextView txtTitulo, txtDuracion;



        public CustomViewHolder(@NonNull View itemView, TextView titulo, TextView duracion)
        {
            super(itemView);
            this.txtDuracion=duracion;
            this.txtTitulo=titulo;
        }

        public TextView getTxtTitulo() {
            return txtTitulo;
        }

        public TextView getTxtDuracion() {
            return txtDuracion;
        }

        public void setTxtTitulo(TextView txtTitulo) {
            this.txtTitulo = txtTitulo;
        }

        public void setTxtDuracion(TextView txtDuracion) {
            this.txtDuracion = txtDuracion;
        }


    }

    @NonNull
    @Override
    public CustomViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        return null;
    }

    @Override
    public void onBindViewHolder(@NonNull CustomViewHolder holder, int position) {

    }

    @Override
    public int getItemCount() {
        return 0;
    }


}
