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


public class MainActivity extends AppCompatActivity implements View.OnClickListener{

    Button btnPlay, btnPause, btnStop;
    Button btnPauseV, btnPlayV;
    MediaPlayer mp;
    VideoView videoView;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        MediaController mediaController= new MediaController(this);
        setContentView(R.layout.activity_main);
        mp = MediaPlayer.create(this, R.raw.s);

        videoView = findViewById(R.id.vdVw);
        //Set MediaController  to enable play, pause, forward, etc options.
        //mediaController.setAnchorView(videoView);
        mediaController.setRotation(90);
        //Location of Media File
        Uri uri = Uri.parse("android.resource://" + getPackageName() + "/" + R.raw.video1);
        //Starting VideView By Setting MediaController and URI
        videoView.setMediaController(mediaController);
        videoView.setVideoURI(uri);
        videoView.requestFocus();
        videoView.start();

        btnPlay = findViewById(R.id.buttonPlay);
        btnPause = findViewById(R.id.buttonPause);
        btnStop = findViewById(R.id.buttonStop);
        btnPauseV = findViewById(R.id.btnPauseV);
        btnPlayV = findViewById(R.id.btnPlayV);

        btnPlay.setOnClickListener(this);
        btnStop.setOnClickListener(this);
        btnPause.setOnClickListener(this);
        btnPauseV.setOnClickListener(this);
        btnPlayV.setOnClickListener(this);
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
        else if(v==btnPauseV)
        {
            videoView.pause();
        }
        else if(v==btnPlayV)
        {
            videoView.start();
        }
    }
}

/*public class MainActivity extends AppCompatActivity {



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
