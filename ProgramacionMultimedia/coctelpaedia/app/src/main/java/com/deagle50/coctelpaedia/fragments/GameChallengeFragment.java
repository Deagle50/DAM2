package com.deagle50.coctelpaedia.fragments;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.TextView;

import androidx.constraintlayout.widget.ConstraintLayout;
import androidx.fragment.app.Fragment;

import com.deagle50.coctelpaedia.R;
import com.deagle50.coctelpaedia.helpers.PlayersOpenHelper;
import com.deagle50.coctelpaedia.helpers.StringHelper;
import com.deagle50.coctelpaedia.helpers.ThemeHelper;

import java.util.ArrayList;
import java.util.Arrays;
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

    private StringHelper phraseStringHelper;

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
        ArrayList<String> stringList = new ArrayList<>(Arrays.asList(gamePhrasesArray));
        phraseStringHelper = new StringHelper(stringList);
        PlayersOpenHelper playersOpenHelper = new PlayersOpenHelper(getContext());

        tvPhrase.setText(String.format("%s, %s.", playersOpenHelper.getRandomPlayer(), phraseStringHelper.getRandomString()));
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
        PlayersOpenHelper playersOpenHelper = new PlayersOpenHelper(getContext());
        if(v==btnPrev)
        {
            isPrevious = true;
            btnPrev.setEnabled(false);

            next = tvPhrase.getText().toString();

            tvPhrase.setText(previous);
        }
        if(v==btnNext)
        {
            previous = tvPhrase.getText().toString();
            if(isFirstLoad)
            {
                btnPrev.setEnabled(true);
                isFirstLoad=false;
                tvPhrase.setText(String.format("%s, %s.", playersOpenHelper.getRandomPlayer(), phraseStringHelper.getRandomString()));
            }
            else{
                if(isPrevious)
                {
                    btnPrev.setEnabled(true);
                    tvPhrase.setText(next);
                    isPrevious=false;

                }
                else{
                    tvPhrase.setText(String.format("%s, %s.", playersOpenHelper.getRandomPlayer(), phraseStringHelper.getRandomString()));
                }
            }


        }
        playersOpenHelper.close();

    }
}
