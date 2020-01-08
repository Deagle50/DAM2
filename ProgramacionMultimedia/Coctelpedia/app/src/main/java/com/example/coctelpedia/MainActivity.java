package com.example.coctelpedia;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.TextView;

import com.google.android.material.bottomnavigation.BottomNavigationView;

public class MainActivity extends AppCompatActivity {
    private BottomNavigationView bottomNavigationView;
    TextView txtTexto;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        txtTexto = findViewById(R.id.txtTexto);

        final Intent iw = new Intent(this, WikiActivity.class);
        final Intent im = new Intent(this, MainActivity.class);


        bottomNavigationView = findViewById(R.id.navigation);
        bottomNavigationView.setOnNavigationItemSelectedListener(new BottomNavigationView.OnNavigationItemSelectedListener() {
            @Override
            public boolean onNavigationItemSelected(@NonNull MenuItem item) {

                if (item.getItemId() == R.id.btnWiki) {
                    startActivity(iw);
                } else if (item.getItemId() == R.id.btnMain) {
                    startActivity(im);
                }
                return true;
            }
        });
    }
}
