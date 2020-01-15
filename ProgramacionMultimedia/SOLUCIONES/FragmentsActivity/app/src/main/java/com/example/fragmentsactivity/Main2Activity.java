package com.example.fragmentsactivity;

import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.FragmentManager;
import androidx.fragment.app.FragmentTransaction;

import android.os.Bundle;

public class Main2Activity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main2);
        Fragment2 f=new Fragment2();
        FragmentManager fm=getSupportFragmentManager();
        FragmentTransaction fr=fm.beginTransaction();
        fr.add(R.id.layout,f);
        fr.commit();
    }
}
