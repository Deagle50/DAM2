package com.deagle50.coctelpaedia.activities;

import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;

import androidx.appcompat.app.AppCompatActivity;
import androidx.navigation.NavController;
import androidx.navigation.Navigation;
import androidx.navigation.ui.AppBarConfiguration;
import androidx.navigation.ui.NavigationUI;

import com.deagle50.coctelpaedia.R;
import com.deagle50.coctelpaedia.helpers.LanguageHelper;
import com.deagle50.coctelpaedia.helpers.ThemeHelper;
import com.google.android.gms.ads.MobileAds;
import com.google.android.gms.ads.initialization.InitializationStatus;
import com.google.android.gms.ads.initialization.OnInitializationCompleteListener;
import com.google.android.material.bottomnavigation.BottomNavigationView;

/*
*
* TO DO:

    * To pass:

    * Extras:
        * Close objects and databases
        * On first load at install, show "Important information" on Coctelpaedia Fragment
        * Load image on theme change
        * Add games
        * Gesture to change between navigationBar fragments
        * Add animation to text on games * https://stackoverflow.com/questions/6700374/android-character-by-character-display-text-animation
        * Add tips and tricks

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

* KNOW BUGS:
    * Scroll on CoctelpediaFragment bugged, idk how to solve it
    * Language sharedPreferences not working well, on load doesn't load properly the saved language, it always goes the default
*
* Credits:
* flags: Freepik
* coctel: Kiranshastry
* */

public class MainActivity extends AppCompatActivity {
    public static MainActivity instance;
    private LanguageHelper languageHelper;
    private ThemeHelper themeHelper;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //ÑAPA to getResources and others from adapters and non-activity classes
        instance = this;

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
        languageHelper = new LanguageHelper(this);
        languageHelper.loadSavedLanguage(this);

        //Load theme
        themeHelper = new ThemeHelper(this);
        themeHelper.loadSavedTheme();

        //Load ad launcher
        MobileAds.initialize(this, new OnInitializationCompleteListener() {
            @Override
            public void onInitializationComplete(InitializationStatus initializationStatus) {
            }
        });
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        //Inflate menu
        getMenuInflater().inflate(R.menu.share_menu, menu);
        return super.onCreateOptionsMenu(menu);
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        //Menu for the share button
        if (item.getItemId() == R.id.menu_Share) {
            Intent i = new Intent(
                    Intent.ACTION_SEND);
            i.setType("text/plain");
            i.putExtra(
                    Intent.EXTRA_TEXT, getResources().getString(R.string.text_share));//Take from string
            startActivity(Intent.createChooser(i, getResources().getString(R.string.title_share_dialog)));
        }
        return super.onOptionsItemSelected(item);

    }

    @Override
    protected void onResume() {
        //Reload saved language onResume
        super.onResume();
        languageHelper.loadSavedLanguage(this);
        themeHelper.loadSavedTheme();
    }

    @Override
    protected void onStart() {
        //Reload saved language onStart
        super.onStart();
        languageHelper.loadSavedLanguage(this);
        themeHelper.loadSavedTheme();
    }

    private void deletePreferences() {
        //Delete the preferences when wanted
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