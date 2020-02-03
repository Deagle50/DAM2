package com.deagle50.coctelpedia.activities;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.app.Dialog;
import android.content.DialogInterface;
import android.database.Cursor;
import android.os.Bundle;
import android.text.InputType;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import com.deagle50.coctelpedia.R;
import com.deagle50.coctelpedia.helpers.JugadoresOpenHelper;

import java.util.ArrayList;

public class GameChallenge extends AppCompatActivity implements View.OnClickListener, AdapterView.OnItemClickListener{
    private Boolean requestAnother = true;
    private String player ="";
    private String playersText = "";
    private ArrayList<String> players = new ArrayList<String>();
    private TextView txtPlayers;
    private Button btnAdd,btnDelete;
    private ListView lista;
    private AlertDialog.Builder builder;
    private Cursor jugadores;
    private int idJugadorSeleccionado;
    private JugadoresOpenHelper joh;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_game_challenge);

        txtPlayers = findViewById(R.id.textViewPlayers);
        btnAdd = findViewById(R.id.buttonAdd);
        btnAdd.setOnClickListener(this);
        btnDelete = findViewById(R.id.buttonDelete);
        btnDelete.setOnClickListener(this);

        lista = findViewById(R.id.listViewJugadores);
        lista.setOnItemClickListener(this);

        joh = new JugadoresOpenHelper(this, "jugadores", null, 1);

        requestPlayers();

    }

    private void requestPlayers() {
        setBuilder();
        builder.show();


    }

    private void setBuilder(){
        builder = new AlertDialog.Builder(this);
        // set title
        builder.setTitle(R.string.title_credits);
        final EditText input = new EditText(this);
        // Specify the type of input expected
        input.setInputType(InputType.TYPE_CLASS_TEXT);
        builder.setView(input);

        // Set up the buttons
        builder.setPositiveButton(R.string.title_add_player, new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                player = input.getText().toString();
                players.add(player);
                playersText += player + " ";

                joh.insertarJugador(player);
                //Volver a pedir jugador
                dialog.dismiss();
            }
        });
        builder.setNeutralButton(R.string.title_close, new DialogInterface.OnClickListener() {
            @Override
            public void onClick(DialogInterface dialog, int which) {
                requestAnother = false;
                dialog.dismiss();
            }
        });
        builder.setOnDismissListener(new DialogInterface.OnDismissListener() {
            @Override
            public void onDismiss(DialogInterface dialog) {
                if(requestAnother) {
                    setBuilder();
                    builder.show();
                }
                else{
                    txtPlayers.setText(playersText);
                    cargarJugadores();
                    //Añadir adapter y mostrar
                }
            }
        });
    }

    @Override
    public void onClick(View v) {
        if(v==btnAdd)
        {
            requestAnother = true;
            setBuilder();
            builder.show();

            //Añadir a adapter
        }
        if(v==btnDelete)
        {
            borrarJugador();
        }
    }

    public void cargarJugadores() {
        jugadores = joh.obtenerJugadores();//Cursor jugadores

        if(jugadores != null) {
            ArrayList<String> nombresJugador = new ArrayList<>();
            while (jugadores.moveToNext()) {
                nombresJugador.add(jugadores.getString(1));
            }
            lista.setAdapter(new ArrayAdapter<String>(this, R.layout.item_jugador, nombresJugador));
        }
    }

    public void borrarJugador() {
        if(idJugadorSeleccionado != -1) {
            if(joh.borrarJugador(idJugadorSeleccionado)) {
                Toast.makeText(this, idJugadorSeleccionado + " Eliminado.", Toast.LENGTH_LONG).show();
                cargarJugadores();
                idJugadorSeleccionado = -1;
            }
        }
    }

    @Override
    public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
        view.setBackgroundColor(getResources().getColor(R.color.colorPrimary, null));

        jugadores.moveToPosition(position);
        idJugadorSeleccionado = jugadores.getInt(0);
        Toast.makeText(this, position + " seleccionado - id:" + idJugadorSeleccionado, Toast.LENGTH_LONG).show();
    }
}
