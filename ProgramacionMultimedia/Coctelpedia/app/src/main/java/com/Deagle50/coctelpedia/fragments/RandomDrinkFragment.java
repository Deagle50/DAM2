package com.deagle50.coctelpedia.fragments;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.constraintlayout.widget.ConstraintLayout;
import androidx.fragment.app.Fragment;

import com.deagle50.coctelpedia.R;
import com.deagle50.coctelpedia.helpers.themeHelper;

import java.util.Objects;

public class RandomDrinkFragment extends Fragment {
    private TextView txtName, txtGraduation;
    private themeHelper themeHelper;
    private ConstraintLayout constraintLayout;
    private View root;

        @Override
        public View onCreateView(LayoutInflater inflater, ViewGroup container,
                                 Bundle savedInstanceState) {
            // Inflate the layout for this fragment

            root = inflater.inflate(R.layout.fragment_random_drink, container, false);
            txtName = root.findViewById(R.id.textViewName);
            txtGraduation = root.findViewById(R.id.textViewGraduation);

            changeBackgroundColor();




            return root;
        }

    private void changeBackgroundColor() {
        constraintLayout = root.findViewById(R.id.cvBackgroundLayout);

        themeHelper = new themeHelper(Objects.requireNonNull(getContext()));
        if(themeHelper.isDark()){
            constraintLayout.setBackgroundColor(getResources().getColor(R.color.backgroundGray, null));
        }
    }
}
