package com.deagle50.coctelpedia.activities;

import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.Toast;

import com.deagle50.coctelpedia.R;
import com.google.android.material.bottomnavigation.BottomNavigationView;

import androidx.appcompat.app.AppCompatActivity;
import androidx.navigation.NavController;
import androidx.navigation.Navigation;
import androidx.navigation.ui.AppBarConfiguration;
import androidx.navigation.ui.NavigationUI;

import com.google.android.gms.ads.MobileAds;
import com.google.android.gms.ads.initialization.InitializationStatus;
import com.google.android.gms.ads.initialization.OnInitializationCompleteListener;

/*
*
* TO DO:
*
* To pass:

* Extras:

    * Load image on theme change
    * Add games
    * Gesture to change between navbar fragments
    * Add animation to text on games
    * Add tips and tricks
    * https://stackoverflow.com/questions/6700374/android-character-by-character-display-text-animation
*
*
* DONE:
    * Dark theme
    * Save language and theme on shared preferences
    * Onclick to change language
    * Put credits
    * Insert names
    * Delete names
    * Coctels table
    * Random coctel game
    * Divide Coctels info into different tables (type, language)
*
* Credits:
* flags: Freepik
* coctel: Kiranshastry
* */

public class MainActivity extends AppCompatActivity {
    public static MainActivity instance;
    private com.deagle50.coctelpedia.helpers.LanguageHelper languageHelper;
    private com.deagle50.coctelpedia.helpers.ThemeHelper themeHelper;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        instance = this; //ÑAPA

        BottomNavigationView navView = findViewById(R.id.nav_view);
        // Passing each menu ID as a set of Ids because each
        // menu should be considered as top level destinations.
        AppBarConfiguration appBarConfiguration = new AppBarConfiguration.Builder(
                R.id.navigation_home, R.id.navigation_coctelpedia, R.id.navigation_games, R.id.navigation_settings)
                .build();
        NavController navController = Navigation.findNavController(this, R.id.nav_host_fragment);
        NavigationUI.setupActionBarWithNavController(this, navController, appBarConfiguration);
        NavigationUI.setupWithNavController(navView, navController);




        //Load language
        languageHelper = new com.deagle50.coctelpedia.helpers.LanguageHelper(MainActivity.this);
        languageHelper.loadSavedLanguage(this);

        //Load theme
        themeHelper = new com.deagle50.coctelpedia.helpers.ThemeHelper(MainActivity.this, this);
        themeHelper.loadSavedTheme();

        //Load ad launcher
        MobileAds.initialize(this, new OnInitializationCompleteListener() {
            @Override
            public void onInitializationComplete(InitializationStatus initializationStatus) {
            }
        });

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
        if (item.getItemId() == R.id.menu_Share) {
            Intent i = new Intent(
                    Intent.ACTION_SEND);
            i.setType("text/plain");
            i.putExtra(
                    Intent.EXTRA_TEXT, "Descarga la aplicacion desde google.es");//Take from string
            startActivity(Intent.createChooser(i, "Title of your share dialog"));
        }
        return super.onOptionsItemSelected(item);

    }

    @Override
    protected void onResume() {
        super.onResume();
        languageHelper.loadSavedLanguage(this);
        themeHelper.loadSavedTheme();
    }

    @Override
    protected void onStart() {
        super.onStart();
        languageHelper.loadSavedLanguage(this);
        themeHelper.loadSavedTheme();
    }

    private void borrarPreferencias() {
        SharedPreferences shpl = this.getSharedPreferences(this.getResources().getString(R.string.preferences_language_file), MODE_PRIVATE);
        SharedPreferences shpt = this.getSharedPreferences(this.getResources().getString(R.string.preferences_theme_file), MODE_PRIVATE);
        SharedPreferences.Editor shple = shpl.edit();
        SharedPreferences.Editor shpte = shpt.edit();
        shpte.clear();
        shple.clear();
        shpte.apply();
        shple.apply();
    }
}