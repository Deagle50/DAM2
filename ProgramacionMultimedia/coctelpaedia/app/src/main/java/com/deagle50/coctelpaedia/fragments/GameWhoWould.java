package com.deagle50.coctelpaedia.fragments;

import android.annotation.SuppressLint;
import android.database.Cursor;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AbsListView;
import android.widget.AdapterView;
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
import java.util.Objects;

public class GameWhoWould extends Fragment {
    private PlayersOpenHelper playersOpenHelper;
    private ListView listViewPlayers, listViewCount;

    View clickSource;
    View touchSource;

    int offset = 0;
    public GameWhoWould() {
    }

    private View root;
    @SuppressLint("ClickableViewAccessibility")
    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        root = inflater.inflate(R.layout.fragment_game_who_would, container, false);


        listViewPlayers = root.findViewById(R.id.listViewPlayersWhoWould);
        listViewCount = root.findViewById(R.id.listViewPlayersCountWhoWould);
        //listViewPlayers.setOnScrollListener(new SyncedScrollListener(listViewCount));
        //listViewCount.setOnScrollListener(new SyncedScrollListener(listViewPlayers));

        setSyncedScroll();
        setClickListener();


        playersOpenHelper = new PlayersOpenHelper(getContext());

        changeBackgroundColor();
        loadPlayers();


        return root;
    }

    private void setClickListener() {
        listViewPlayers.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                if(parent == clickSource) {
                    // Do something with the ListView was clicked
                }
            }
        });
    }

    @SuppressLint("ClickableViewAccessibility")
    private void setSyncedScroll() {
        listViewPlayers.setOnTouchListener(new View.OnTouchListener() {
            @Override
            public boolean onTouch(View v, MotionEvent event) {
                if(touchSource == null)
                    touchSource = v;

                if(v == touchSource) {
                    listViewCount.dispatchTouchEvent(event);
                    if(event.getAction() == MotionEvent.ACTION_UP) {
                        clickSource = v;
                        touchSource = null;
                    }
                }

                return false;
            }
        });

        listViewPlayers.setOnScrollListener(new AbsListView.OnScrollListener() {
            @Override
            public void onScroll(AbsListView view, int firstVisibleItem, int visibleItemCount, int totalItemCount) {
                if(view == clickSource)
                    listViewCount.setSelectionFromTop(firstVisibleItem, view.getChildAt(0).getTop() + offset);
            }

            @Override
            public void onScrollStateChanged(AbsListView view, int scrollState) {}
        });


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
            ArrayList<String> players = new ArrayList<>();
            ArrayList<Integer> counter = new ArrayList<>();
            while (cursorPlayers.moveToNext()) {
                players.add(cursorPlayers.getString(1));
                counter.add(0);
            }

            //Show the items on the listViewPlayers
            listViewPlayers.setAdapter(new ArrayAdapter<>(Objects.requireNonNull(getContext()), R.layout.item_player, R.id.textViewPlayerName, players));
            listViewCount.setAdapter(new ArrayAdapter<>(Objects.requireNonNull(getContext()), R.layout.item_player, R.id.textViewPlayerName, counter));
        }
    }
}
