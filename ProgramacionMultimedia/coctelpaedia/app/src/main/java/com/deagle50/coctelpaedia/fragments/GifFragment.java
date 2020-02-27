package com.deagle50.coctelpaedia.fragments;

import android.os.Bundle;
import android.os.CountDownTimer;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.constraintlayout.widget.ConstraintLayout;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentTransaction;

import com.deagle50.coctelpaedia.R;
import com.deagle50.coctelpaedia.helpers.ThemeHelper;

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

        ThemeHelper themeHelper = new ThemeHelper(Objects.requireNonNull(getContext()));
        if(themeHelper.isDark()){
            constraintLayout.setBackgroundColor(getResources().getColor(R.color.backgroundGray, null));
        }
    }

    private void changeFragment() {

        new CountDownTimer(3000, 1000) {
            String[] numbers={getString(R.string.title_3), getString(R.string.title_2), getString(R.string.title_1), getString(R.string.title_0)};
            TextView textViewCount = root.findViewById(R.id.textViewCountGifFragment);
            int i = 0;
            @Override
            public void onTick(long millisUntilFinished) {
                textViewCount.setText(numbers[i]);
                i++;
            }

            @Override
            public void onFinish() {
                assert getFragmentManager() != null;
                FragmentTransaction transaction = getFragmentManager().beginTransaction();
                transaction.replace(R.id.containerGif, new RandomDrinkFragment());
                transaction.commit();
            }
        }.start();
/*
        final Handler handler = new Handler();
        handler.postDelayed(new Runnable() {
            @Override
            public void run() {
                //Do something after 1000ms
                assert getFragmentManager() != null;
                FragmentTransaction transaction = getFragmentManager().beginTransaction();
                transaction.replace(R.id.containerGif, new RandomDrinkFragment());
                transaction.commit();
            }
        }, 2000);*/
    }
}

