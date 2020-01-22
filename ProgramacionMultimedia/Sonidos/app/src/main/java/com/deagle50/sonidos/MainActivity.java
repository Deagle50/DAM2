package com.deagle50.sonidos;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import android.media.MediaPlayer;
import android.net.Uri;
import android.os.Bundle;
import android.os.PersistableBundle;
import android.view.View;
import android.widget.Button;
import android.widget.MediaController;
import android.widget.VideoView;


public class MainActivity extends AppCompatActivity {
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        VideoView videoView = findViewById(R.id.vdVw);
        //Set MediaController  to enable play, pause, forward, etc options.
        MediaController mediaController= new MediaController(this);
        //mediaController.setAnchorView(videoView);
        mediaController.setRotation(90);
        //Location of Media File
        Uri uri = Uri.parse("android.resource://" + getPackageName() + "/" + R.raw.video1);
        //Starting VideView By Setting MediaController and URI
        videoView.setMediaController(mediaController);
        videoView.setVideoURI(uri);
        videoView.requestFocus();
        videoView.start();
    }
}

/*public class MainActivity extends AppCompatActivity implements View.OnClickListener{

    MediaController mediaController= new MediaController(this);
    Button btnPlay, btnPause, btnStop;
    MediaPlayer mp;

    @Override
    public void onCreate(@Nullable Bundle savedInstanceState, @Nullable PersistableBundle persistentState) {
        VideoView videoView =findViewById(R.id.vdVw);
        super.onCreate(savedInstanceState);
        mediaController.setAnchorView(videoView);
        Uri uri = Uri.parse("android.resource://" + getPackageName() + "/" + R.raw.video1);
        videoView.setMediaController(mediaController);
        videoView.setVideoURI(uri);
        videoView.requestFocus();
        videoView.start();

        setContentView(R.layout.activity_main);
        mp = MediaPlayer.create(this, R.raw.s);

        btnPlay = findViewById(R.id.buttonPlay);
        btnPause = findViewById(R.id.buttonPause);
        btnStop = findViewById(R.id.buttonStop);


        btnPlay.setOnClickListener(this);
        btnStop.setOnClickListener(this);
        btnPause.setOnClickListener(this);
    }


    @Override
    public void onClick(View v) {
        if (v==btnPause) {
            mp.pause();
        }
        else if(v==btnPlay)
        {
            mp.start();
        }
        else if(v==btnStop)
        {
            mp.stop();
            mp=MediaPlayer.create(this, R.raw.a);
        }
    }
}

/*public class MainActivity extends AppCompatActivity implements View.OnClickListener{
    Button btnPlay, btnPause, btnStop;
    MediaPlayer mp;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        mp = MediaPlayer.create(this, R.raw.s);

        btnPlay = findViewById(R.id.buttonPlay);
        btnPause = findViewById(R.id.buttonPause);
        btnStop = findViewById(R.id.buttonStop);


        btnPlay.setOnClickListener(this);
        btnStop.setOnClickListener(this);
        btnPause.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {
        if (v==btnPause) {
            mp.pause();
        }
        else if(v==btnPlay)
        {
            mp.start();
        }
        else if(v==btnStop)
        {
            mp.stop();
            mp=MediaPlayer.create(this, R.raw.a);
        }
    }
}*/
