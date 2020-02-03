package com.deagle50.bibliotecasonidos;

import android.database.Cursor;
import android.net.Uri;
import android.provider.MediaStore;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

public class SongsAdapter extends RecyclerView.Adapter<SongsAdapter.CustomViewHolder> implements View.OnClickListener {
    Cursor cursor;
    int resource;
    Uri cancionSeleccionada;

    public SongsAdapter(int id, Cursor c)
    {
        resource = id;
        cursor = c;
        //cursor.moveToFirst();
    }

    public Uri getCancionSeleccionada() {
        return cancionSeleccionada;
    }



    class CustomViewHolder extends RecyclerView.ViewHolder {
        Button btnSelect;
        TextView txtTitulo, txtDuracion;



        public CustomViewHolder(@NonNull View itemView, TextView titulo, TextView duracion, Button btn)
        {
            super(itemView);
            this.txtDuracion=duracion;
            this.txtTitulo=titulo;
            this.btnSelect = btn;
        }

        public TextView getTxtTitulo() {
            return txtTitulo;
        }

        public TextView getTxtDuracion() {
            return txtDuracion;
        }

        public void setTxtTitulo(String titulo) {
            txtTitulo.setText(titulo);
        }

        public void setTxtDuracion(String duracion) {
            txtDuracion.setText(duracion);
        }

        public void setBtnTag(Uri selectedSong)
        {
            btnSelect.setTag(selectedSong);
        }

        public void setButtonClickListener(View.OnClickListener listener)
        {
            btnSelect.setOnClickListener(listener);
        }
    }

    @NonNull
    @Override
    public CustomViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        LinearLayout layout = (LinearLayout)((MainActivity) parent.getContext())
                .getLayoutInflater()
                .inflate(R.layout.song_item, parent, false);

        TextView txtTitulo, txtDuracion;
        Button btnSelect;

        txtTitulo = parent.findViewById(R.id.textViewTitulo);
        txtDuracion= parent.findViewById(R.id.textViewDuracion);
        btnSelect = parent.findViewById(R.id.buttonPlay);

        CustomViewHolder vh = new CustomViewHolder(layout, txtTitulo, txtDuracion, btnSelect);

        vh.setButtonClickListener(this);

        return null;
    }

    @Override
    public void onClick(View v) {
        cancionSeleccionada = (Uri) v.getTag();
        //MediaStore.Pla
    }

    @Override
    public void onBindViewHolder(@NonNull CustomViewHolder holder, int position) {
        cursor.moveToPosition(position);
        holder.setBtnTag(Uri.parse(cursor.getString(0)));
        holder.setTxtTitulo(cursor.getString(1));
        holder.setTxtDuracion(cursor.getString(2));
    }

    @Override
    public int getItemCount() {
        return 0;
    }


}
