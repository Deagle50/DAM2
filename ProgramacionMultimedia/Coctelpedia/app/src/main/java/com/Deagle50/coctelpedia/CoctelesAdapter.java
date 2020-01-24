package com.deagle50.coctelpedia;

import android.graphics.Bitmap;
import android.provider.ContactsContract;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.CheckBox;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.cardview.widget.CardView;
import androidx.recyclerview.widget.RecyclerView;

import java.util.List;

public class CoctelesAdapter extends RecyclerView.Adapter<CoctelesAdapter.CoctelViewHolder>{
    List<Coctel> coctels;

    public CoctelesAdapter(List<Coctel> coctels){
        this.coctels = coctels;
    }

    @Override
    public void onAttachedToRecyclerView(RecyclerView recyclerView) {
        super.onAttachedToRecyclerView(recyclerView);
    }

    @Override
    public CoctelViewHolder onCreateViewHolder(ViewGroup viewGroup, int i) {
        View v = LayoutInflater.from(viewGroup.getContext()).inflate(R.layout.item_coctel, viewGroup, false);
        CoctelViewHolder cvh = new CoctelViewHolder(v);
        return cvh;
    }

    @Override
    public void onBindViewHolder(CoctelViewHolder coctelViewHolder, int i) {
        ViewGroup.LayoutParams params = coctelViewHolder.tvDescripcion.getLayoutParams();


        coctelViewHolder.tvCoctel.setText(coctels.get(i).getNombre());
        coctelViewHolder.tvDescripcion.setText(coctels.get(i).getDescripcion());
        coctelViewHolder.tvElaboracion.setText(coctels.get(i).getElaboracion());
        coctelViewHolder.tvCasa.setText(coctels.get(i).getPrecioC().toString()+"€");
        coctelViewHolder.tvBar.setText(coctels.get(i).getPrecioB().toString()+"€");
        coctelViewHolder.tvGraduacion.setText(coctels.get(i).getGraduacion().toString()+" º");
        if(coctels.get(i).isVegano())
        {
            coctelViewHolder.cbVegano.setChecked(true);
            coctelViewHolder.cbVegetariano.setChecked(true);
        }
            else if(coctels.get(i).isVegetariano())
        {
            coctelViewHolder.cbVegetariano.setChecked(true);

        }


        if(coctels.get(i).getUrlFoto().equals(""))
        {
            coctelViewHolder.imageViewCoctel.setImageResource(R.drawable.coctel);
        }
        }
        //coctelViewHolder.imageViewCoctel.setImageResource(coctels.get(i).getUrlFoto())

    @Override
    public int getItemCount() {
        return coctels.size();
    }

    public static class CoctelViewHolder extends RecyclerView.ViewHolder {
        CardView cv;
        TextView tvCoctel, tvDescripcion, tvGraduacion, tvCasa, tvBar, tvElaboracion;
        ImageView imageViewCoctel;
        CheckBox cbVegano, cbVegetariano;

        CoctelViewHolder(View itemView) {
            super(itemView);
            cv = itemView.findViewById(R.id.CardViewCoctel);
            imageViewCoctel = itemView.findViewById(R.id.imageViewCoctel);
            tvCoctel = itemView.findViewById(R.id.textViewCoctel);
            tvElaboracion = itemView.findViewById(R.id.textViewElaboracion);
            tvGraduacion = itemView.findViewById(R.id.textViewGraduacion);
            tvCasa= itemView.findViewById(R.id.textViewCasa);
            tvBar= itemView.findViewById(R.id.textViewBar);
            tvDescripcion= itemView.findViewById(R.id.textViewDescripcion);
            cbVegetariano=itemView.findViewById(R.id.checkBoxVegetariano);
            cbVegano=itemView.findViewById(R.id.checkBoxVegano);
        }


    }



}