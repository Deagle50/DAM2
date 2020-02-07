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
import androidx.fragment.app.FragmentTransaction;

import com.deagle50.coctelpedia.activities.GameWhoWhould;
import com.deagle50.coctelpedia.R;
import com.deagle50.coctelpedia.helpers.JugadoresOpenHelper;
import com.deagle50.coctelpedia.fragments.GifFragment;

import java.util.ArrayList;

import static com.deagle50.coctelpedia.activities.MainActivity.instance;

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
    public void onClick(View v) {
        switch(v.getId()) {
            case R.id.buttonGameRandomDrink:
            {

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

                break;
            }
            case R.id.buttonGameChallenge:
            {
                if(cursorPlayers.getCount()==0)
                {
                    Toast.makeText(instance, R.string.title_must_add_player, Toast.LENGTH_SHORT).show();

                }else
                if(cursorPlayers.getCount()==1)
                {
                    Toast.makeText(instance, R.string.title_must_add_moreplayers, Toast.LENGTH_SHORT).show();
                }
                else{
                    FragmentTransaction transaction = getFragmentManager().beginTransaction();
                    transaction.replace(R.id.container, new GameChallenge());

                    transaction.addToBackStack(null);

                    // Commit the transaction
                    transaction.commit();
                }
                //Intent i = new Intent(getActivity(), PlayersActivity.class);
                //startActivity(i);
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

    private void loadPlayers() {
        JugadoresOpenHelper jugadoresOpenHelper = new JugadoresOpenHelper(getContext(), "cursorPlayers", null, 1);
        cursorPlayers = jugadoresOpenHelper.getPlayers();//Cursor cursorPlayers

        if(cursorPlayers != null) {
            ArrayList<String> players = new ArrayList<>();
            while (cursorPlayers.moveToNext()) {
                players.add(cursorPlayers.getString(1));
            }
        }
    }
}