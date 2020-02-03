package com.deagle50.coctelpedia.fragments;

import android.content.Intent;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;

import com.deagle50.coctelpedia.activities.GameChallenge;
import com.deagle50.coctelpedia.activities.GameWhoWhould;
import com.deagle50.coctelpedia.R;

public class GamesFragment extends Fragment implements View.OnClickListener{
    //Quién es más probable que...
    //Yo nunca
    //Verdad o reto
    //

    Button btnGWhoWould;
    Button btnGChallenge;
    public View root;


    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {

        root = inflater.inflate(R.layout.fragment_games, container, false);
        btnGWhoWould = root.findViewById(R.id.buttonGameWhoWould);
        btnGWhoWould.setOnClickListener(this);
        btnGChallenge = root.findViewById(R.id.buttonGameChallenge);
        btnGChallenge.setOnClickListener(this);

        return root;
    }

    @Override
    public void onClick(View v) {
        switch(v.getId()) {
            case R.id.buttonGameWhoWould:
                {
                    Intent i = new Intent(getActivity(), GameWhoWhould.class);
                    startActivity(i);
                    break;
                }
            case R.id.buttonGameChallenge:
            {
                Intent i = new Intent(getActivity(), GameChallenge.class);
                startActivity(i);
                break;
            }
            case R.id.btnJuego3:
            {
                //Add listener
                break;
            }
            default:
                break;
        }

    }
}