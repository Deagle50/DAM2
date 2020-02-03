package com.deagle50.coctelpedia.activities;

import android.content.Intent;
import android.content.SharedPreferences;
import android.graphics.Color;
import android.os.Bundle;
import android.text.Html;
import android.text.Spannable;
import android.text.SpannableString;
import android.text.style.ForegroundColorSpan;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.TextView;

import com.deagle50.coctelpedia.R;
import com.deagle50.coctelpedia.helpers.languageHelper;
import com.deagle50.coctelpedia.helpers.themeHelper;
import com.google.android.material.bottomnavigation.BottomNavigationView;

import androidx.appcompat.app.ActionBar;
import androidx.appcompat.app.AppCompatActivity;
import androidx.navigation.NavController;
import androidx.navigation.Navigation;
import androidx.navigation.ui.AppBarConfiguration;
import androidx.navigation.ui.NavigationUI;

/*
*
* TO DO:
*
*Para aprobar:
   *Tabla de cocteles
* Extras
    * Cargar imagen nueva en modo oscuro
    * Añadir juegos
    * Gesto para cambiar entre fragments pantalla principal
*
*
* DONE:
    * Modo oscuro
    * Guardar modo oscuro e idioma en shared preferences
    * Implementar bien idiomas, onclick
    * Poner créditos
    * Insert nombres
    * Delete de nombres
*
* Credits:
* flags: Freepik
* coctel: Kiranshastry
* */

public class MainActivity extends AppCompatActivity {
    public static MainActivity instancia;
    languageHelper lh;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        instancia = this;//ÑAPA

        BottomNavigationView navView = findViewById(R.id.nav_view);
        // Passing each menu ID as a set of Ids because each
        // menu should be considered as top level destinations.
        AppBarConfiguration appBarConfiguration = new AppBarConfiguration.Builder(
                R.id.navigation_home, R.id.navigation_coctelpedia, R.id.navigation_games, R.id.navigation_settings)
                .build();
        NavController navController = Navigation.findNavController(this, R.id.nav_host_fragment);
        NavigationUI.setupActionBarWithNavController(this, navController, appBarConfiguration);
        NavigationUI.setupWithNavController(navView, navController);


        //Cargar idioma
        lh = new languageHelper(MainActivity.this);
        lh.loadSavedLanguage(this);


        //Cargar tema
        themeHelper th = new themeHelper(MainActivity.this, this);
        th.loadSavedTheme();


        //Change action bar color
        //int titleId = getResources().getIdentifier("action_bar_title", "id", "android");
        /*TextView abTitle = findViewById(getResources().getIdentifier("action_bar_title", "id", "android"));
        abTitle.setTextColor(getResources().getColor(R.color.fontGray, null));*/

    }


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.share_menu, menu);
        return super.onCreateOptionsMenu(menu);
    }

    @Override

    public boolean onOptionsItemSelected(MenuItem item) {

        switch (item.getItemId()) {

            case R.id.menu_Share:

                Intent i = new Intent(

                        android.content.Intent.ACTION_SEND);

                i.setType("text/plain");

                i.putExtra(

                        android.content.Intent.EXTRA_TEXT, "Descarga la aplicacion desde google.es");

                startActivity(Intent.createChooser(

                        i,

                        "Title of your share dialog"));

                break;

        }

        return super.onOptionsItemSelected(item);

    }

    @Override
    protected void onResume() {
        super.onResume();
        lh.loadSavedLanguage(this);
    }

    @Override
    protected void onStart() {
        super.onStart();
        lh.loadSavedLanguage(this);
    }

    private void borrarPreferencias() {
        SharedPreferences shpl = this.getSharedPreferences(this.getResources().getString(R.string.preferences_language_file), this.MODE_PRIVATE);
        SharedPreferences shpt = this.getSharedPreferences(this.getResources().getString(R.string.preferences_theme_file), this.MODE_PRIVATE);
        SharedPreferences.Editor shple = shpl.edit();
        SharedPreferences.Editor shpte = shpt.edit();
        shpte.clear();
        shple.clear();
        shpte.commit();
        shple.commit();
    }
}
