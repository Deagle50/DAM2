package com.deagle50.coctelpedia.fragments;

import android.database.Cursor;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.CheckBox;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.constraintlayout.widget.ConstraintLayout;
import androidx.fragment.app.Fragment;

import com.deagle50.coctelpedia.Coctel;
import com.deagle50.coctelpedia.R;
import com.deagle50.coctelpedia.helpers.CoctelsOpenHelper;

import java.util.Objects;

public class RandomDrinkFragment extends Fragment {
    private com.deagle50.coctelpedia.helpers.ThemeHelper themeHelper;
    private ConstraintLayout constraintLayout;
    private View root;

        @Override
        public View onCreateView(LayoutInflater inflater, ViewGroup container,
                                 Bundle savedInstanceState) {
            // Inflate the layout for this fragment

            root = inflater.inflate(R.layout.fragment_random_drink, container, false);


            changeBackgroundColor();

            loadRandomCoctel();

            return root;
        }

    private void changeBackgroundColor() {
        constraintLayout = root.findViewById(R.id.cvBackgroundLayout);

        themeHelper = new com.deagle50.coctelpedia.helpers.ThemeHelper(Objects.requireNonNull(getContext()));
        if(themeHelper.isDark()){
            constraintLayout.setBackgroundColor(getResources().getColor(R.color.backgroundGray, null));
        }
    }

    private void loadRandomCoctel() {


        CoctelsOpenHelper coctelsOpenHelper = new CoctelsOpenHelper(getContext(), null, null, 1);
        Cursor cursorCoctels = coctelsOpenHelper.getRandomCoctel();
        cursorCoctels.moveToFirst();
        Coctel coctel = new Coctel(cursorCoctels.getString(1), cursorCoctels.getInt(2),
                cursorCoctels.getFloat(3), cursorCoctels.getFloat(4),
                cursorCoctels.getFloat(5), cursorCoctels.getString(6),
                cursorCoctels.getString(7), cursorCoctels.getInt(8)>0,
                cursorCoctels.getInt(9)>0, cursorCoctels.getString(10));

        TextView txtName = root.findViewById(R.id.textViewName);
        txtName.setText(coctel.getName());
        TextView txtGraduation = root.findViewById(R.id.textViewGraduation);
        txtGraduation.setText(coctel.getGraduation().toString()+"º");
        TextView txtMaking = root.findViewById(R.id.textViewMaking2);
        txtMaking.setText(coctel.getElaboration());
        TextView txtDescription = root.findViewById(R.id.textViewDescription4);
        txtDescription.setText(coctel.getDescription());
        TextView txtBar = root.findViewById(R.id.textViewPub4);
        txtBar.setText(coctel.getPriceB().toString()+" €");
        TextView txtHome = root.findViewById(R.id.textViewHome4);
        txtHome.setText(coctel.getPriceH().toString()+" €");

        CheckBox cbVegan = root.findViewById(R.id.checkBoxVegan3);
        CheckBox cbVegetarian = root.findViewById(R.id.checkBoxVegetarian3);
        ImageView imageView = root.findViewById(R.id.imageViewCoctel2);

        if(coctel.isVegan())
        {

            cbVegan.setChecked(true);
            cbVegetarian.setChecked(true);
        }
        else if(coctel.isVegetarian())
        {
            cbVegetarian.setChecked(true);
        }
        if(coctel.getUrlPhoto()==1)
        {
            imageView.setImageResource(R.drawable.coctel);
        }
        else{
            imageView.setImageResource(coctel.getUrlPhoto());
    }
}

}
