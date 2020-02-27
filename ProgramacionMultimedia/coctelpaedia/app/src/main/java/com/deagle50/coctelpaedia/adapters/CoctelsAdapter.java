package com.deagle50.coctelpaedia.adapters;

import android.annotation.SuppressLint;
import android.app.Activity;
import android.app.FragmentTransaction;
import android.content.Context;
import android.view.GestureDetector;
import android.view.LayoutInflater;
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewGroup;
import android.widget.CheckBox;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.cardview.widget.CardView;
import androidx.recyclerview.widget.RecyclerView;

import com.deagle50.coctelpaedia.Coctel;
import com.deagle50.coctelpaedia.R;
import com.deagle50.coctelpaedia.fragments.CoctelInfoFragment;

import java.util.ArrayList;

import static com.deagle50.coctelpaedia.activities.MainActivity.instance;


public class CoctelsAdapter extends RecyclerView.Adapter<CoctelsAdapter.CoctelViewHolder>{
    private GestureDetector detector;
    private ArrayList<Coctel> coctels;
    private Coctel actualCoctel;

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
        View v = LayoutInflater.from(viewGroup.getContext()).inflate(R.layout.item_coctel_light, viewGroup, false);
        Context context = viewGroup.getContext();

        detector = new GestureDetector(context, new GestureListener());

        return new CoctelViewHolder(v);
    }

    @SuppressLint("ClickableViewAccessibility")
    @Override
    public void onBindViewHolder(final CoctelViewHolder coctelViewHolder, int i) {
        //Load the data to the view on each item
        i = coctelViewHolder.getAdapterPosition();

        coctelViewHolder.tvCoctel.setText(coctels.get(i).getName());
        coctelViewHolder.tvHome.setText(String.format("%s€", coctels.get(i).getPriceH().toString()));
        coctelViewHolder.tvBar.setText(String.format("%s€", coctels.get(i).getPriceB().toString()));
        coctelViewHolder.tvGraduation.setText(String.format("%s º", coctels.get(i).getGraduation().toString()));
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
            //If urlPhoto is empty load default photo
            coctelViewHolder.imageViewCoctel.setImageResource(R.drawable.coctel);
        }
        else{
            coctelViewHolder.imageViewCoctel.setImageResource(coctels.get(i).getUrlPhoto());
        }

        coctelViewHolder.cv.setOnTouchListener(new View.OnTouchListener() {

            @Override
            public boolean onTouch(View v, MotionEvent event) {
            actualCoctel = coctels.get(coctelViewHolder.getAdapterPosition());
            return detector.onTouchEvent(event);
            }
        });
    }



    @Override
    public int getItemCount() {
        return coctels.size();
    }

    class CoctelViewHolder extends RecyclerView.ViewHolder {
        CardView cv;
        TextView tvCoctel, tvGraduation, tvHome, tvBar, tvType;
        ImageView imageViewCoctel;
        CheckBox cbVegetarian, cbVegan;

        @SuppressLint("ClickableViewAccessibility")
        CoctelViewHolder(final View itemView) {
            super(itemView);
            cv = itemView.findViewById(R.id.CardViewCoctelLight);
            imageViewCoctel = itemView.findViewById(R.id.imageViewCoctelLight);
            tvCoctel = itemView.findViewById(R.id.textViewNameLight);
            tvGraduation = itemView.findViewById(R.id.textViewGraduationLight);
            tvHome = itemView.findViewById(R.id.textViewPriceH2Light);
            tvBar= itemView.findViewById(R.id.textViewPriceB2Light);
            cbVegetarian =itemView.findViewById(R.id.checkBoxVegetarianLight);
            cbVegan =itemView.findViewById(R.id.checkBoxVeganLight);
            tvType = itemView.findViewById(R.id.textViewTypeLight);

        }
    }

    public class GestureListener extends GestureDetector.SimpleOnGestureListener {

        @Override
        public boolean onDown(MotionEvent e) {
            return true;
        }
        @Override
        public boolean onDoubleTap(MotionEvent e) {
            //In the future, the items of the recyclerView will have less info,
            //and onDoubleTap all the info will be shown
            loadInfoFragment();
            return true;
        }



        @Override
        public void onLongPress(MotionEvent e) {
            super.onLongPress(e);
            loadInfoFragment();
        }
    }

    private void loadInfoFragment() {
        Activity activity = instance;
        FragmentTransaction transaction = activity.getFragmentManager().beginTransaction().
                replace(R.id.containerCoctelpedia, new CoctelInfoFragment(actualCoctel), "tagFragmentCoctelInfo").
                addToBackStack("tagFragmentCoctelPedia");
        transaction.commit();
    }


}