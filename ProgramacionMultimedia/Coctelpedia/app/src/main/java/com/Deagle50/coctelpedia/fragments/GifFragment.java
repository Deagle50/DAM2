package com.deagle50.coctelpedia.fragments;

import androidx.constraintlayout.widget.ConstraintLayout;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentTransaction;

import android.os.Bundle;
import android.os.Handler;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import com.deagle50.coctelpedia.R;
import com.deagle50.coctelpedia.helpers.themeHelper;
import com.deagle50.coctelpedia.fragments.RandomDrinkFragment;

import java.util.Objects;


public class GifFragment extends Fragment {
    private View root;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment

        root = inflater.inflate(R.layout.fragment_gif, container, false);


        changeFragment();
        changeBackgroundColor();

        return root;
    }

    private void changeBackgroundColor() {
        ConstraintLayout constraintLayout = root.findViewById(R.id.cvGifBackground);

        themeHelper themeHelper = new themeHelper(Objects.requireNonNull(getContext()));
        if(themeHelper.isDark()){
            constraintLayout.setBackgroundColor(getResources().getColor(R.color.backgroundGray, null));
        }
    }

    private void changeFragment() {
        final Handler handler = new Handler();
        handler.postDelayed(new Runnable() {
            @Override
            public void run() {
                //Do something after 1000ms
                FragmentTransaction transaction = getFragmentManager().beginTransaction();
                transaction.replace(R.id.containerGif, new RandomDrinkFragment());

                // Commit the transaction
                transaction.commit();
            }
        }, 2000);
    }
}

