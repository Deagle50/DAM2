package com.Deagle50.coctelpedia.fragments;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.CheckBox;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.cardview.widget.CardView;
import androidx.recyclerview.widget.RecyclerView;

import com.deagle50.coctelpedia.Coctel;
import com.deagle50.coctelpedia.R;

import java.util.ArrayList;

public class CoctelesAdapter extends RecyclerView.Adapter<CoctelesAdapter.CoctelViewHolder>{
    private ArrayList<Coctel> coctels;

    public CoctelesAdapter(ArrayList<Coctel> coctels){
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
        coctelViewHolder.tvCoctel.setText(coctels.get(i).getName());
        coctelViewHolder.tvDescription.setText(coctels.get(i).getDescription());
        coctelViewHolder.tvElaboration.setText(coctels.get(i).getElaboration());
        coctelViewHolder.tvHome.setText(coctels.get(i).getPriceH().toString()+"€");
        coctelViewHolder.tvBar.setText(coctels.get(i).getPriceB().toString()+"€");
        coctelViewHolder.tvGraduation.setText(coctels.get(i).getGraduation().toString()+" º");

        if(coctels.get(i).isVegan())
        {
            coctelViewHolder.cbVegan.setChecked(true);
            coctelViewHolder.cbVegetarian.setChecked(true);
        }
            else if(coctels.get(i).isVegetarian())
        {
            coctelViewHolder.cbVegetarian.setChecked(true);

        }


        if(coctels.get(i).getUrlPhoto()==1)
        {
            coctelViewHolder.imageViewCoctel.setImageResource(R.drawable.coctel);
        }
        else{
            coctelViewHolder.imageViewCoctel.setImageResource(coctels.get(i).getUrlPhoto());
        }

        coctelViewHolder.tvType.setText(coctels.get(i).getType());
        }



    @Override
    public int getItemCount() {
        return coctels.size();
    }

    public static class CoctelViewHolder extends RecyclerView.ViewHolder {
        CardView cv;
        TextView tvCoctel, tvDescription, tvGraduation, tvHome, tvBar, tvElaboration, tvType;
        ImageView imageViewCoctel;
        CheckBox cbVegetarian, cbVegan;

        CoctelViewHolder(View itemView) {
            super(itemView);
            cv = itemView.findViewById(R.id.CardViewCoctel);
            imageViewCoctel = itemView.findViewById(R.id.imageViewCoctel);
            tvCoctel = itemView.findViewById(R.id.textViewCoctel);
            tvElaboration = itemView.findViewById(R.id.textViewElaboracion);
            tvGraduation = itemView.findViewById(R.id.textViewGraduacion);
            tvHome = itemView.findViewById(R.id.textViewCasa);
            tvBar= itemView.findViewById(R.id.textViewBar);
            tvDescription = itemView.findViewById(R.id.textViewDescripcion);
            cbVegetarian =itemView.findViewById(R.id.checkBoxVegetariano);
            cbVegan =itemView.findViewById(R.id.checkBoxVegano);
            tvType = itemView.findViewById(R.id.textViewType);
        }


    }



}