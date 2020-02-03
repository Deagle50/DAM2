package com.deagle50.coctelpedia.activities;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.DialogInterface;
import android.database.Cursor;
import android.os.Bundle;
import android.text.InputType;
import android.view.View;
import android.view.ViewGroup;
import android.view.inputmethod.InputMethodManager;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Toast;

import com.deagle50.coctelpedia.R;
import com.deagle50.coctelpedia.helpers.JugadoresOpenHelper;
import com.google.android.material.floatingactionbutton.FloatingActionButton;

import java.util.ArrayList;

public class PlayersActivity extends AppCompatActivity implements View.OnClickListener, AdapterView.OnItemClickListener{
    private String player ="";
    private ArrayList<String> players = new ArrayList<String>();
    private FloatingActionButton btnAdd,btnDelete;
    private ListView list;
    private AlertDialog.Builder builder;
    private Cursor cursorPlayers;
    private int selectedPlayerID =-1;
    private JugadoresOpenHelper jugadoresOpenHelper;
    private EditText input;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_players);


        input = new EditText(this);
        btnAdd = findViewById(R.id.buttonAdd);
        btnAdd.setOnClickListener(this);
        btnDelete = findViewById(R.id.buttonDelete);
        btnDelete.setOnClickListener(this);

        list = findViewById(R.id.listViewJugadores);
        list.setOnItemClickListener(this);

        jugadoresOpenHelper = new JugadoresOpenHelper(this, "cursorPlayers", null, 1);


        loadPlayers();
        if(cursorPlayers==null)
        {
            requestPlayer();
        }
        else if(cursorPlayers.getCount()==0)
        {
            requestPlayer();
        }
    }

    @Override
    public void onClick(View v) {
        if(v==btnAdd)
        {
            requestPlayer();
        }
        if(v==btnDelete)
        {
            deletePlayer();
        }
    }

    @Override
    public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
        //loadPlayers();
        //view.setBackgroundColor(getResources().getColor(R.color.colorPrimary, null));
        cursorPlayers.moveToPosition(position);
        selectedPlayerID = cursorPlayers.getInt(0);
    }

    private void setBuilder(){
        builder = new AlertDialog.Builder(this);
        // set title
        builder.setTitle(R.string.title_players);

        // Specify the type of input expected
        input.setInputType(InputType.TYPE_CLASS_TEXT);
        input.setHint(getString(R.string.title_put_name));
        input.setText("");
        builder.setView(input);

        // Set up the buttons
        builder.setPositiveButton(R.string.title_add_player, new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                if(input.getText().toString().equals(""))
                {
                    error();
                }else{
                    player = input.getText().toString();
                    players.add(player);

                    jugadoresOpenHelper.insertPlayer(player);
                }
                dialog.dismiss();
            }
        });
        builder.setNeutralButton(R.string.title_close, new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {

                dialog.dismiss();
            }
        });
        builder.setOnDismissListener(new DialogInterface.OnDismissListener() {
            @Override
            public void onDismiss(DialogInterface dialog) {
                loadPlayers();
            }
        });

    }

    private void error() {
        Toast.makeText(this, getString(R.string.title_empty_name), Toast.LENGTH_SHORT).show();
    }

    private void requestPlayer() {
        loadPlayers();
        setBuilder();
        if(input.getParent()!=null)
        {
            ((ViewGroup) input.getParent()).removeView(input);
        }
        //Try to show soft keyboard on builder show
        InputMethodManager imm = (InputMethodManager) getSystemService(Context.INPUT_METHOD_SERVICE);
        imm.showSoftInput(input, InputMethodManager.SHOW_IMPLICIT);
        builder.show();
    }

    public void loadPlayers() {
        cursorPlayers = jugadoresOpenHelper.getPlayers();//Cursor cursorPlayers

        if(cursorPlayers != null) {
            players = new ArrayList<>();
            while (cursorPlayers.moveToNext()) {
                players.add(cursorPlayers.getString(1));
            }
            list.setAdapter(new ArrayAdapter<String>(this, R.layout.item_jugador, R.id.textViewNombre, players));
        }
        else{
        }
    }

    public void deletePlayer() {
        if(selectedPlayerID != -1) {
            if(jugadoresOpenHelper.deletePlayer(selectedPlayerID)) {
                Toast.makeText(this, cursorPlayers.getString(1) + " " + getString(R.string.title_deleted), Toast.LENGTH_SHORT).show();
                loadPlayers();
                selectedPlayerID = -1;
            }
        }
        else{
            Toast.makeText(this, getString(R.string.title_must_select_player), Toast.LENGTH_SHORT).show();
        }
    }

}
