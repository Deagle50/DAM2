package com.deagle50.coctelpedia.fragments;

import android.content.Intent;
import android.database.Cursor;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;

import com.deagle50.coctelpedia.activities.GameWhoWhould;
import com.deagle50.coctelpedia.R;
import com.deagle50.coctelpedia.helpers.JugadoresOpenHelper;

import java.util.ArrayList;

import static com.deagle50.coctelpedia.activities.MainActivity.instance;

public class GamesFragment extends Fragment implements View.OnClickListener{
    //Quién es más probable que...
    //Yo nunca
    //Verdad o reto
    //

    Button btnGWhoWould;
    Button btnGChallenge;
    Button btnPlayers;
    public View root;
    JugadoresOpenHelper jugadoresOpenHelper;
    Cursor cursorPlayers;

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {

        root = inflater.inflate(R.layout.fragment_games, container, false);

        btnGWhoWould = root.findViewById(R.id.buttonGameWhoWould);
        btnGWhoWould.setOnClickListener(this);
        btnGChallenge = root.findViewById(R.id.buttonGameChallenge);
        btnGChallenge.setOnClickListener(this);
        btnPlayers = root.findViewById(R.id.buttonPlayers);
        btnPlayers.setOnClickListener(this);


        loadPlayers();
        return root;
    }

    @Override
    public void onResume() {
        super.onResume();
        loadPlayers();
    }

    @Override
    public void onClick(View v) {
        switch(v.getId()) {
            case R.id.buttonGameWhoWould:
                {
                    if(cursorPlayers.getCount()==0)
                    {
                        Toast.makeText(instance, "error", Toast.LENGTH_SHORT).show();

                    }
                    else{
                        Intent i = new Intent(getActivity(), GameWhoWhould.class);
                        startActivity(i);
                    }
                    break;
                }
            case R.id.buttonGameChallenge:
            {
                //Intent i = new Intent(getActivity(), PlayersActivity.class);
                //startActivity(i);
                break;
            }
            case R.id.btnJuego3:
            {
                //Add listener
                break;
            }
            case R.id.buttonPlayers:
                Intent i = new Intent(getActivity(), com.deagle50.coctelpedia.activities.PlayersActivity.class);
                startActivity(i);
                break;
            default:
                break;
        }

    }

    public void loadPlayers() {
        jugadoresOpenHelper = new JugadoresOpenHelper(getContext(), "cursorPlayers", null, 1);
        cursorPlayers = jugadoresOpenHelper.getPlayers();//Cursor cursorPlayers

        if(cursorPlayers != null) {
            ArrayList<String> players = new ArrayList<>();
            while (cursorPlayers.moveToNext()) {
                players.add(cursorPlayers.getString(1));
            }
        }
    }
}