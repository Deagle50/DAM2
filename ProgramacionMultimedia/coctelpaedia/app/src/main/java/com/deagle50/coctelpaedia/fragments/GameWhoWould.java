package com.deagle50.coctelpaedia.fragments;

import android.database.Cursor;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.constraintlayout.widget.ConstraintLayout;
import androidx.fragment.app.Fragment;

import com.deagle50.coctelpaedia.R;
import com.deagle50.coctelpaedia.helpers.PlayersOpenHelper;
import com.deagle50.coctelpaedia.helpers.ThemeHelper;

import java.util.ArrayList;
import java.util.Locale;
import java.util.Objects;

public class GameWhoWould extends Fragment {
    private PlayersOpenHelper playersOpenHelper;
    private ArrayList<String> players = new ArrayList<>();
    private ListView listView;
    public GameWhoWould() {
    }

    View root;
    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        root = inflater.inflate(R.layout.fragment_game_who_would, container, false);


        listView = root.findViewById(R.id.listViewPlayersWhoWould);
        playersOpenHelper = new PlayersOpenHelper(getContext());

        changeBackgroundColor();
        loadPlayers();


        return root;
    }

    private void changeBackgroundColor() {
        ConstraintLayout constraintLayout = root.findViewById(R.id.cvGameWhoWhouldBackground);

        ThemeHelper themeHelper = new ThemeHelper(Objects.requireNonNull(getContext()));
        if(themeHelper.isDark()){
            constraintLayout.setBackgroundColor(getResources().getColor(R.color.backgroundGray, null));
        }
    }

    private void loadPlayers() {
        //Load all the players on the cursor
        Cursor cursorPlayers = playersOpenHelper.getPlayers();//Cursor cursorPlayers

        if(cursorPlayers != null) {
            //Pass the cursor to a ArrayList
            players = new ArrayList<>();
            while (cursorPlayers.moveToNext()) {
                players.add(cursorPlayers.getString(1));
            }
            //Show the items on the listview
            listView.setAdapter(new ArrayAdapter<>(Objects.requireNonNull(getContext()), R.layout.item_jugador, R.id.textViewNombre, players));
        }
    }
}
