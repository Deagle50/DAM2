package com.deagle50.coctelpaedia.activities;

import android.annotation.SuppressLint;
import android.content.DialogInterface;
import android.database.Cursor;
import android.os.Bundle;
import android.text.InputType;
import android.view.GestureDetector;
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import com.deagle50.coctelpaedia.R;
import com.deagle50.coctelpaedia.helpers.PlayersOpenHelper;
import com.deagle50.coctelpaedia.helpers.LanguageHelper;
import com.google.android.material.floatingactionbutton.FloatingActionButton;

import java.util.ArrayList;
import java.util.Locale;

public class PlayersActivity extends AppCompatActivity implements View.OnClickListener, AdapterView.OnItemClickListener{
    private GestureDetector detector;
    private String player ="";
    private ArrayList<String> players = new ArrayList<>();
    private FloatingActionButton btnAdd,btnDelete;
    private ListView listView;
    private AlertDialog.Builder insertBuilder;
    private AlertDialog.Builder updateBuilder;
    private Cursor cursorPlayers;
    private int selectedPlayerID =-1;
    private PlayersOpenHelper playersOpenHelper;
    private EditText input;
    private TextView txtCount;

    @Override
    protected void onResume() {
        //Load language
        LanguageHelper languageHelper;
        languageHelper = new LanguageHelper(this);
        languageHelper.loadSavedLanguage(this);

        super.onResume();
    }

    @Override
    protected void onStart() {
        //Load language
        LanguageHelper languageHelper;
        languageHelper = new LanguageHelper(this);
        languageHelper.loadSavedLanguage(this);

        super.onStart();
    }

    @SuppressLint("ClickableViewAccessibility")
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_players);


        input = new EditText(this);
        btnAdd = findViewById(R.id.buttonAdd);
        btnAdd.setOnClickListener(this);
        btnDelete = findViewById(R.id.buttonDelete);
        btnDelete.setOnClickListener(this);

        txtCount = findViewById(R.id.textViewCount);

        listView = findViewById(R.id.listViewJugadores);
        listView.setOnItemClickListener(this);

        playersOpenHelper = new PlayersOpenHelper(this);


        //Load the listView with the players from the database, if there are any
        loadPlayers();
        if(cursorPlayers==null)
        {
            requestPlayer();
        }
        else if(cursorPlayers.getCount()==0)
        {
            requestPlayer();
        }

        //Load language
        LanguageHelper languageHelper;
        languageHelper = new LanguageHelper(this);
        languageHelper.loadSavedLanguage(this);

        detector = new GestureDetector(this, new GestureListener());

        listView.setOnTouchListener(new View.OnTouchListener() {

            @Override
            public boolean onTouch(View v, MotionEvent event) {
                return detector.onTouchEvent(event);
            }
        });
    }

    @Override
    public void onClick(View v) {
        if(v==btnAdd)
        {
            //Request new player
            requestPlayer();
        }
        if(v==btnDelete)
        {
            //Delete the selected player
            deletePlayer();
        }
    }

    @Override
    public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
        //Save selected player and load it on cursor
        cursorPlayers.moveToPosition(position);
        selectedPlayerID = cursorPlayers.getInt(0);
    }

    private void setInsertBuilder(){
        //Set the dialog for insert players
        insertBuilder = new AlertDialog.Builder(this);
        // set title
        insertBuilder.setTitle(R.string.title_players);

        //Specify the type of input
        input.setInputType(InputType.TYPE_CLASS_TEXT);
        input.setHint(getString(R.string.title_put_name));
        input.setText("");
        insertBuilder.setView(input);

        //Set up the buttons
        insertBuilder.setPositiveButton(R.string.title_add_player, new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                if(input.getText().toString().equals(""))
                {
                    nameError();
                }else{
                    player = input.getText().toString();
                    players.add(player);

                    playersOpenHelper.insertPlayer(player);
                }
                dialog.dismiss();
            }
        });
        insertBuilder.setNeutralButton(R.string.title_close, new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {

                dialog.dismiss();
            }
        });
        insertBuilder.setOnDismissListener(new DialogInterface.OnDismissListener() {
            @Override
            public void onDismiss(DialogInterface dialog) {
                //Reload players on dialog close
                loadPlayers();
            }
        });

    }

    private void setUpdateBuilder(){
        //Set the dialog for update players
        updateBuilder = new AlertDialog.Builder(this);
        // set title
        updateBuilder.setTitle(R.string.title_players);

        // Specify the type of input expected
        input.setInputType(InputType.TYPE_CLASS_TEXT);
        input.setHint(getString(R.string.title_put_name));
        input.setText("");
        updateBuilder.setView(input);

        // Set up the buttons
        updateBuilder.setPositiveButton(R.string.title_update_player, new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                if(input.getText().toString().equals(""))
                {
                    nameError();
                }else{
                    String playerName = input.getText().toString();
                    if(playersOpenHelper.updatePlayer(selectedPlayerID, playerName)){
                        Toast.makeText(getApplicationContext(), cursorPlayers.getString(1)+" " + getResources().getString(R.string.title_updated), Toast.LENGTH_SHORT).show();
                    }

                }
                dialog.dismiss();
            }
        });
        updateBuilder.setNeutralButton(R.string.title_close, new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {

                dialog.dismiss();
            }
        });
        updateBuilder.setOnDismissListener(new DialogInterface.OnDismissListener() {
            @Override
            public void onDismiss(DialogInterface dialog) {
                //Reload players on dialog close
                loadPlayers();
            }
        });

    }

    private void nameError() {
        //Name field can't be empty
        Toast.makeText(this, getString(R.string.title_empty_name), Toast.LENGTH_SHORT).show();
    }

    private void requestPlayer() {
        //Request new player, first reload the listview to show without blue background
        loadPlayers();
        setInsertBuilder();
        if(input.getParent()!=null)
        {
            ((ViewGroup) input.getParent()).removeView(input);
        }
        //Show the builder to insert player
        insertBuilder.show();
    }

    public void loadPlayers() {
        //Load all the players on the cursor
        cursorPlayers = playersOpenHelper.getPlayers();//Cursor cursorPlayers

        if(cursorPlayers != null) {
            //Pass the cursor to a ArrayList
            players = new ArrayList<>();
            while (cursorPlayers.moveToNext()) {
                players.add(cursorPlayers.getString(1));
            }
            //Show the items on the listview
            listView.setAdapter(new ArrayAdapter<>(this, R.layout.item_jugador, R.id.textViewNombre, players));
        }
        //Put the players count
        txtCount.setText(String.format(Locale.getDefault(), "%d", players.size()));
    }

    public void deletePlayer() {
        //Delete the player if its selected any
        if(selectedPlayerID != -1) {
            if(playersOpenHelper.deletePlayer(selectedPlayerID)) {
                Toast.makeText(this, cursorPlayers.getString(1) + " " + getString(R.string.title_deleted), Toast.LENGTH_SHORT).show();
                loadPlayers();
                selectedPlayerID = -1;
            }
        }
        else{
            //If nothing selected toast
            Toast.makeText(this, getString(R.string.title_must_select_player), Toast.LENGTH_SHORT).show();
        }
    }


    public void updatePlayer(){
        //Update selected player
        if(selectedPlayerID != -1) {
            setUpdateBuilder();
            if(input.getParent()!=null)
            {
                ((ViewGroup) input.getParent()).removeView(input);
            }
            updateBuilder.show();
        }
        else
        {
            Toast.makeText(this, getResources().getString(R.string.title_must_select_player), Toast.LENGTH_SHORT).show();
        }

    }

    public class GestureListener extends GestureDetector.SimpleOnGestureListener {
        //This is the gesture listener to listen LongPress and DoubleTap on ListView
        @Override
        public void onLongPress(MotionEvent e) {

            updatePlayer();
            super.onLongPress(e);
        }

        @Override
        public boolean onDown(MotionEvent e) {
            return true;
        }
        @Override
        public boolean onDoubleTap(MotionEvent e) {
            updatePlayer();
            return true;
        }

    }



}
