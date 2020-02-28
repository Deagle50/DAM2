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
import com.deagle50.coctelpaedia.helpers.PlayersOpenHelper;
import com.deagle50.coctelpaedia.helpers.StringHelper;
import com.deagle50.coctelpaedia.helpers.ThemeHelper;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Objects;

public class GameChallengeFragment extends Fragment implements View.OnClickListener{
    private View root;
    private TextView tvPhrase;
    private Button btnNext;
    private Button btnPrev;

    private Boolean isFirstLoad = true;

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

        saveAndSet();
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

        if(v==btnPrev)//Puts previous phrase on TextView
        {
            getPrev();
        }
        if(v==btnNext) {
            getNext();
        }
    }

    private void getPrev() {
        String previous = phraseStringHelper.getPreviousString();
        if(previous==null)
            Toast.makeText(getContext(), "There is no previous phrase", Toast.LENGTH_SHORT).show();
        else
            tvPhrase.setText(previous);
    }

    private void getNext() {
        if(isFirstLoad)
        {
            btnPrev.setEnabled(true);
            isFirstLoad=false;
        }
        saveAndSet();
    }

    private void saveAndSet(){
        PlayersOpenHelper playersOpenHelper = new PlayersOpenHelper(getContext());
        if(phraseStringHelper.i<phraseStringHelper.newStrings.size()-1)
        {
            tvPhrase.setText(phraseStringHelper.getNextString());
        }
        else {
            String stringToSave = playersOpenHelper.getRandomPlayer() + ", " + phraseStringHelper.getNextString() + ".";
            phraseStringHelper.saveString(stringToSave);
            tvPhrase.setText(stringToSave);
        }
        playersOpenHelper.close();
    }

}
