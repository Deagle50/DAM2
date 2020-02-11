package com.deagle50.coctelpaedia.fragments;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import androidx.constraintlayout.widget.ConstraintLayout;
import androidx.fragment.app.Fragment;

import com.deagle50.coctelpaedia.R;
import com.deagle50.coctelpaedia.helpers.StringHelper;
import com.deagle50.coctelpaedia.helpers.ThemeHelper;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Objects;

public class GameChallengeFragment extends Fragment implements View.OnClickListener{
    private TextView tvPhrase;
    private Button btnNext;
    private Button btnPrev;

    private String previous;
    private String next;

    private View root;
    private Boolean isFirstLoad = true;
    private Boolean isPrevious = false;

    private StringHelper stringHelper;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment

        root = inflater.inflate(R.layout.fragment_game_challenge, container, false);

        tvPhrase = root.findViewById(R.id.textViewPhrase);
        btnNext = root.findViewById(R.id.buttonNextChallenge);
        btnPrev = root.findViewById(R.id.buttonPreviousChallenge);
        btnNext.setOnClickListener(this);
        btnPrev.setOnClickListener(this);



        changeBackgroundColor();
        initialLoad();

        return root;
    }

    private void initialLoad() {
        btnPrev.setEnabled(false);
        String[] gamePhrasesArray;
        gamePhrasesArray = getResources().getStringArray(R.array.game_challenge);
        List<String> stringList = new ArrayList<String>(Arrays.asList(gamePhrasesArray));
        stringHelper = new StringHelper((ArrayList<String>) stringList);

        tvPhrase.setText(stringHelper.getRandomString());
    }

    private void changeBackgroundColor() {
        ConstraintLayout constraintLayout = root.findViewById(R.id.cvGameChallenge);

        ThemeHelper themeHelper = new ThemeHelper(Objects.requireNonNull(getContext()));
        if(themeHelper.isDark()){
            constraintLayout.setBackgroundColor(getResources().getColor(R.color.backgroundGray, null));
        }
    }

    @Override
    public void onClick(View v) {

        if(v==btnPrev)
        {
            Toast.makeText(getContext(), "PreviousString", Toast.LENGTH_SHORT).show();
            isPrevious = true;
            btnPrev.setEnabled(false);
            previous= stringHelper.getPreviousString();
            next = stringHelper.getNextString();

            tvPhrase.setText(previous);
        }
        if(v==btnNext)
        {
            if(!isFirstLoad)
            {
                if(!isPrevious)
                {
                    tvPhrase.setText(stringHelper.getRandomString());
                }
                else{
                    btnPrev.setEnabled(true);
                    tvPhrase.setText(next);
                    isPrevious=false;

                }
            }
            else{
                btnPrev.setEnabled(true);
                isFirstLoad=false;
            }


        }


    }
}
