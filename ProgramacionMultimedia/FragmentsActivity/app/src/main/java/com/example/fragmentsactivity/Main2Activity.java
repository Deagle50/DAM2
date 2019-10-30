package com.example.fragmentsactivity;

import android.os.Bundle;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentManager;
import androidx.fragment.app.FragmentTransaction;

public class Main2Activity extends AppCompatActivity {
    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main2);
        Fragment2 f = new Fragment2();
        FragmentManager fm=getSupportFragmentManager();
        FragmentTransaction fr = fm.beginTransaction();
        fr.add(f,null);
        fr.commit();
    }
}
