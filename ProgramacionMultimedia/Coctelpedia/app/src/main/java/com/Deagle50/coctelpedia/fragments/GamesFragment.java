package com.Deagle50.coctelpedia.fragments;

import android.content.Intent;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;

import com.Deagle50.coctelpedia.activities.JGQuienMasProbable;
import com.deagle50.coctelpedia.R;

public class GamesFragment extends Fragment implements View.OnClickListener{
    //Quién es más probable que...
    //Yo nunca
    //Verdad o reto
    //

    Button btnJuego1;
    public View root;


    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {

        root = inflater.inflate(R.layout.fragment_games, container, false);
        btnJuego1 = root.findViewById(R.id.btnQEMP);
        btnJuego1.setOnClickListener(this);

        return root;
    }

    @Override
    public void onClick(View v) {
        switch(v.getId()) {
            case R.id.btnQEMP:
                {
                    Intent i = new Intent(getActivity(), JGQuienMasProbable.class);
                    startActivity(i);
                    break;
                }
            case R.id.btnJuego2:
            {
                break;
            }
            case R.id.btnJuego3:
            {
                break;
            }
            default:
                break;
        }

    }
}