package com.deagle50.bibliotecasonidos;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.app.ActivityCompat;
import androidx.recyclerview.widget.RecyclerView;

import android.Manifest;
import android.database.Cursor;
import android.media.MediaPlayer;
import android.os.Bundle;
import android.provider.MediaStore;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

import java.io.IOException;

public class MainActivity extends AppCompatActivity implements View.OnClickListener{
    RecyclerView rv;
    Button btnPlay;
    MediaPlayer mp;
    SongsAdapter adapter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        ActivityCompat.requestPermissions(this, new String[]{Manifest.permission.READ_EXTERNAL_STORAGE}, 1);

        btnPlay = findViewById(R.id.buttonPlay);
        btnPlay.setOnClickListener(this);

        String[] columnas = {MediaStore.Audio.Media.DATA, MediaStore.Audio.Media.TITLE, MediaStore.Audio.Media.DURATION};
        Cursor c = getContentResolver().query(MediaStore.Audio.Media.EXTERNAL_CONTENT_URI, columnas,
                null, null, null);

        adapter = new SongsAdapter(R.layout.song_item, c);

        rv = new RecyclerView(this);
        rv.setAdapter(adapter);
    }

    @Override
    public void onClick(View v) {
        if(mp!=null)
        {
            try {
                mp.setDataSource(this, adapter.getCancionSeleccionada());
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
        else{
            mp = MediaPlayer.create(this, adapter.getCancionSeleccionada());
        }
        mp.start();
        Toast.makeText(this, adapter.getCancionSeleccionada().toString(),
                Toast.LENGTH_SHORT).show();
    }
}
