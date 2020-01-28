package com.deagle50.coctelpedia.activities;

import android.content.Intent;
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
    * Insert nombres
    * Delete de nombres
*
* Extras
    * Cargar imagen nueva en modo oscuro
    * Guardar modo oscuro e idioma en shared preferences
    * Implementar bien idiomas, onclick
    * Añadir juegos
    * Gesto para cambiar entre fragments pantalla principal
    * Cancelar toasts
*
*
* DONE:
*
    * Modo oscuro
*
* flags:
* coctel: Kiranshastry
* */

public class MainActivity extends AppCompatActivity {
    public static MainActivity instancia;

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

        /*SharedPreferences shp = this.getSharedPreferences(this.getResources().getString(R.string.preferences_theme_file), this.MODE_PRIVATE);
        SharedPreferences.Editor shpe = shp.edit();
        shpe.clear();
        shpe.commit();*/

        themeHelper th = new themeHelper(MainActivity.this, this);
        th.loadSavedTheme();

        //Change action bar color
        //int titleId = getResources().getIdentifier("action_bar_title", "id", "android");
        /*TextView abTitle = findViewById(getResources().getIdentifier("action_bar_title", "id", "android"));
        abTitle.setTextColor(getResources().getColor(R.color.fontGray, null));*/



        languageHelper lh = new languageHelper(MainActivity.this);
        lh.loadSavedLanguage(this);
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
}
