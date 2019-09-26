package com.example.recursos;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    @Override
    public void onTextChanged(CharSequence s, int start, int before, int count){
        String pal;
        int num=Integer.parseInt(s.toString());
    }
}
