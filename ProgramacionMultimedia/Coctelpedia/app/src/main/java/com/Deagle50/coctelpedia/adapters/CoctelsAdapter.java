package com.Deagle50.coctelpedia.adapters;

import android.annotation.SuppressLint;
import android.app.Activity;
import androidx.fragment.app.Fragment;

import android.content.Context;
import android.util.Log;
import android.view.GestureDetector;
import android.view.LayoutInflater;
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewGroup;
import android.widget.CheckBox;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.cardview.widget.CardView;
import androidx.recyclerview.widget.RecyclerView;


import com.deagle50.coctelpedia.Coctel;
import com.deagle50.coctelpedia.R;

import java.security.AccessController;
import java.util.ArrayList;
import java.util.Calendar;

import static com.deagle50.coctelpedia.activities.MainActivity.instance;


public class CoctelsAdapter extends RecyclerView.Adapter<CoctelsAdapter.CoctelViewHolder>{
    private GestureDetector detector;
    private ArrayList<Coctel> coctels;
    Context context;

    public CoctelsAdapter(ArrayList<Coctel> coctels){

        this.coctels = coctels;
    }

    @Override
    public void onAttachedToRecyclerView(@NonNull RecyclerView recyclerView) {
        super.onAttachedToRecyclerView(recyclerView);
    }

    @NonNull
    @Override
    public CoctelViewHolder onCreateViewHolder(ViewGroup viewGroup, int i) {
        View v = LayoutInflater.from(viewGroup.getContext()).inflate(R.layout.item_coctel, viewGroup, false);
        context = viewGroup.getContext();

        detector = new GestureDetector(context, new GestureListener());//////

        return new CoctelViewHolder(v);


    }

    @Override
    public void onBindViewHolder(CoctelViewHolder coctelViewHolder, int i) {
        i = coctelViewHolder.getAdapterPosition();


        coctelViewHolder.tvCoctel.setText(coctels.get(i).getName());
        coctelViewHolder.tvDescription.setText(coctels.get(i).getDescription());
        coctelViewHolder.tvElaboration.setText(coctels.get(i).getElaboration());
        coctelViewHolder.tvHome.setText(coctels.get(i).getPriceH().toString()+"€");
        coctelViewHolder.tvBar.setText(coctels.get(i).getPriceB().toString()+"€");
        coctelViewHolder.tvGraduation.setText(coctels.get(i).getGraduation().toString()+" º");
        coctelViewHolder.tvType.setText(coctels.get(i).getType());

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

        //Set background color dark gray if it's on dark theme
        com.deagle50.coctelpedia.helpers.ThemeHelper themeHelper = new com.deagle50.coctelpedia.helpers.ThemeHelper(context);
        if(themeHelper.isDark())
            coctelViewHolder.cv.setBackgroundColor(instance.getResources().getColor(R.color.backgroundGray, null));


    }



    @Override
    public int getItemCount() {
        return coctels.size();
    }

    class CoctelViewHolder extends RecyclerView.ViewHolder {
        CardView cv;
        TextView tvCoctel, tvDescription, tvGraduation, tvHome, tvBar, tvElaboration, tvType;
        ImageView imageViewCoctel;
        CheckBox cbVegetarian, cbVegan;

        @SuppressLint("ClickableViewAccessibility")
        CoctelViewHolder(View itemView) {
            super(itemView);
            cv = itemView.findViewById(R.id.CardViewCoctel);
            imageViewCoctel = itemView.findViewById(R.id.imageViewCoctel2);
            tvCoctel = itemView.findViewById(R.id.textViewCoctel);
            tvElaboration = itemView.findViewById(R.id.textViewElaboracion);
            tvGraduation = itemView.findViewById(R.id.textViewGraduacion);
            tvHome = itemView.findViewById(R.id.textViewCasa);
            tvBar= itemView.findViewById(R.id.textViewBar);
            tvDescription = itemView.findViewById(R.id.textViewDescripcion);
            cbVegetarian =itemView.findViewById(R.id.checkBoxVegetariano);
            cbVegan =itemView.findViewById(R.id.checkBoxVegano);
            tvType = itemView.findViewById(R.id.textViewType);




            cv.setOnTouchListener(new View.OnTouchListener() {

                @Override
                public boolean onTouch(View v, MotionEvent event) {
                    return detector.onTouchEvent(event);
                }
            });

        }
    }

    public class GestureListener extends GestureDetector.SimpleOnGestureListener {

        @Override
        public boolean onDown(MotionEvent e) {
            return true;
        }
        @Override
        public boolean onDoubleTap(MotionEvent e) {
            Log.e("onDoubleTap", e.getAction() + "");
            Toast.makeText(context, "doubletap", Toast.LENGTH_SHORT).show();
            return true;
        }
    }

}