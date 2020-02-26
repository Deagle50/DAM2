package com.deagle50.coctelpaedia.fragments;

import android.database.Cursor;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentTransaction;

import com.deagle50.coctelpaedia.R;
import com.deagle50.coctelpaedia.helpers.PlayersOpenHelper;

import java.util.ArrayList;

import static com.deagle50.coctelpaedia.activities.MainActivity.instance;

public class GamesFragment extends Fragment implements View.OnClickListener{
    //Quién es más probable que...
    //Yo nunca
    //Verdad o reto
    //

    private Cursor cursorPlayers;

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {

        View root = inflater.inflate(R.layout.fragment_games, container, false);

        Button btnGWhoWould = root.findViewById(R.id.buttonGameWhoWould);
        btnGWhoWould.setOnClickListener(this);
        Button btnGChallenge = root.findViewById(R.id.buttonGameChallenge);
        btnGChallenge.setOnClickListener(this);
        Button btnPlayers = root.findViewById(R.id.buttonPlayers);
        btnPlayers.setOnClickListener(this);
        Button btnRandomDrink = root.findViewById(R.id.buttonGameRandomDrink);
        btnRandomDrink.setOnClickListener(this);


        loadPlayers();
        return root;
    }

    @Override
    public void onResume() {
        super.onResume();
        loadPlayers();
    }

    @Override
    public void onStart() {
        super.onStart();
        loadPlayers();
    }

    @Override
    public void onClick(View v) {
        switch(v.getId()) {
            case R.id.buttonGameRandomDrink:
            {

                assert getFragmentManager() != null;
                FragmentTransaction transaction = getFragmentManager().beginTransaction();

                // Replace whatever is in the fragment_container view with this fragment,
                // and add the transaction to the back stack so the user can navigate back
                transaction.replace(R.id.container, new GifFragment());
                transaction.addToBackStack(null);

                // Commit the transaction
                transaction.commit();

                break;
            }
            case R.id.buttonGameWhoWould:
            {
                if(checkPlayers()) {
                    assert getFragmentManager() != null;
                    FragmentTransaction transaction = getFragmentManager().beginTransaction();
                    transaction.replace(R.id.container, new GameWhoWould());

                    transaction.addToBackStack(null);
                    transaction.commit();
                }
                break;
            }
            case R.id.buttonGameChallenge:
            {
                if(checkPlayers()) {
                    assert getFragmentManager() != null;
                    FragmentTransaction transaction = getFragmentManager().beginTransaction();
                    transaction.replace(R.id.container, new GameChallengeFragment());

                    transaction.addToBackStack(null);

                    // Commit the transaction
                    transaction.commit();
                }
                //Intent i = new Intent(getActivity(), PlayersActivity.class);
                //startActivity(i);
                break;
            }

            case R.id.buttonPlayers:
                assert getFragmentManager() != null;
                FragmentTransaction transaction = getFragmentManager().beginTransaction();
                transaction.replace(R.id.container, new PlayersFragment());

                transaction.addToBackStack(null);
                transaction.commit();
                break;
            default:
                break;
        }

    }

    private boolean checkPlayers() {
        loadPlayers();
        if(cursorPlayers.getCount()==0)
        {
            Toast.makeText(instance, R.string.title_must_add_player, Toast.LENGTH_SHORT).show();
            return false;
        }else
        if(cursorPlayers.getCount()==1)
        {
            Toast.makeText(instance, R.string.title_must_add_moreplayers, Toast.LENGTH_SHORT).show();
            return false;
        }
        else {
            return true;
        }
    }

    private void loadPlayers() {
        PlayersOpenHelper playersOpenHelper = new PlayersOpenHelper(getContext());
        cursorPlayers = playersOpenHelper.getPlayers();//Cursor cursorPlayers

        if(cursorPlayers != null) {
            ArrayList<String> players = new ArrayList<>();
            while (cursorPlayers.moveToNext()) {
                players.add(cursorPlayers.getString(1));
            }
        }
        playersOpenHelper.close();
    }
}