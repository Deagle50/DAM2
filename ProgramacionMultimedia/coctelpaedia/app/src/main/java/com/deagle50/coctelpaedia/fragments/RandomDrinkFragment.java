package com.deagle50.coctelpaedia.fragments;

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

import com.deagle50.coctelpaedia.helpers.ThemeHelper;
import com.deagle50.coctelpaedia.Coctel;
import com.deagle50.coctelpaedia.R;
import com.deagle50.coctelpaedia.helpers.CoctelsOpenHelper;

import java.util.Objects;

public class RandomDrinkFragment extends Fragment {
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
        ConstraintLayout constraintLayout = root.findViewById(R.id.cvBackgroundLayout);

        ThemeHelper themeHelper = new ThemeHelper(Objects.requireNonNull(getContext()));
        if(themeHelper.isDark()){
            constraintLayout.setBackgroundColor(getResources().getColor(R.color.backgroundGray, null));
        }
    }

    private void loadRandomCoctel() {
        CoctelsOpenHelper coctelsOpenHelper = new CoctelsOpenHelper(getContext());
        Cursor cursorCoctels = coctelsOpenHelper.getRandomCoctel();
        cursorCoctels.moveToFirst();

        Coctel coctel = new Coctel(cursorCoctels.getString(1), cursorCoctels.getInt(2),
                cursorCoctels.getFloat(3), cursorCoctels.getFloat(4),
                cursorCoctels.getFloat(5), cursorCoctels.getString(6),
                cursorCoctels.getString(7), cursorCoctels.getInt(8)>0,
                cursorCoctels.getInt(9)>0, cursorCoctels.getString(10));

        TextView txtName = root.findViewById(R.id.textViewName);
        TextView txtGraduation = root.findViewById(R.id.textViewGraduation);
        TextView txtMaking = root.findViewById(R.id.textViewMaking2RandomDrink);
        TextView txtDescription = root.findViewById(R.id.textViewDescription2RandomDrink);
        TextView txtBar = root.findViewById(R.id.textViewPub4);
        TextView txtHome = root.findViewById(R.id.textViewHome4);

        CheckBox cbVegan = root.findViewById(R.id.checkBoxVegan3);
        CheckBox cbVegetarian = root.findViewById(R.id.checkBoxVegetarian3);
        ImageView imageView = root.findViewById(R.id.imageViewCoctel2);

        txtName.setText(coctel.getName());
        txtGraduation.setText(String.format("%sº", coctel.getGraduation().toString()));
        txtMaking.setText(coctel.getElaboration());
        txtDescription.setText(coctel.getDescription());
        txtBar.setText(String.format("%s €", coctel.getPriceB().toString()));
        txtHome.setText(String.format("%s €", coctel.getPriceH().toString()));

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
        else
        {
            imageView.setImageResource(coctel.getUrlPhoto());
        }
    coctelsOpenHelper.close();
}

}
