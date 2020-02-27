package com.deagle50.coctelpaedia.helpers;

import android.content.Context;
import android.content.SharedPreferences;
import android.content.res.Configuration;

import androidx.appcompat.app.AppCompatDelegate;

import com.deagle50.coctelpaedia.R;

import static android.content.Context.MODE_PRIVATE;
import static com.deagle50.coctelpaedia.activities.MainActivity.instance;

public class ThemeHelper{

    private Configuration configuration;
    private Context context;
    private boolean savedThemeDark;

    public ThemeHelper(Context context)
    {
        this.context = context;
        SharedPreferences shp = context.getSharedPreferences(context.getResources().getString(R.string.preferences_theme_file), MODE_PRIVATE);
        savedThemeDark = shp.getBoolean(context.getResources().getString(R.string.preferences_isdark), false);
    }

    public void changeTheme(String themeToChange){

        //Change theme
            if(themeToChange.equals("dark"))//If theme to change is dark
            {
                //If current theme isn't dark
                if(!isDark())
                {
                    loadDark();
                }
            } else//If theme to change is light
            if(themeToChange.equals("light"))
            {
                if(isDark())//Check if current theme is light
                {
                    loadLight();
                }
            }
    }

    private Configuration getConfiguration(){
        if (configuration == null) {
            configuration = context.getResources().getConfiguration();
        }
        return configuration;
    }

    private int getUI(){
        return getConfiguration().uiMode;
    }

    public boolean isDark(){
        //Returns true if current theme is dark
        int ui = getUI();
        int currentNightMode = ui & Configuration.UI_MODE_NIGHT_MASK;
        return currentNightMode == Configuration.UI_MODE_NIGHT_YES;
    }

    public void saveTheme(){
        SharedPreferences shp = context.getSharedPreferences(context.getResources().getString(R.string.preferences_theme_file), MODE_PRIVATE);
        SharedPreferences.Editor editor = shp.edit();
        if(isDark()) {
            editor.putBoolean(context.getResources().getString(R.string.preferences_isdark), true);
        }
        else {
            editor.putBoolean(context.getResources().getString(R.string.preferences_isdark), false);
        }
        editor.apply();
    }

    private void loadDark(){
        AppCompatDelegate.setDefaultNightMode(AppCompatDelegate.MODE_NIGHT_YES);
        instance.recreate();
    }

    private void loadLight(){
        AppCompatDelegate.setDefaultNightMode(AppCompatDelegate.MODE_NIGHT_NO);
        instance.recreate();

    }

    public void loadSavedTheme() {
        //Load the saved theme
        if(savedThemeDark)//If the saved theme is dark
        {
            if(!isDark()){//If current theme is light, loads dark
                loadDark();
            }
        }
        else//If the saved theme is light
        {
            if(isDark())//If current theme is dark, loads light
            {
                loadLight();
            }
        }

    }

}