package com.deagle50.coctelpedia.helpers;

import android.content.Context;
import android.content.Intent;
import android.content.res.Configuration;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.app.AppCompatDelegate;

import com.deagle50.coctelpedia.R;
import com.deagle50.coctelpedia.activities.MainActivity;

import static com.deagle50.coctelpedia.activities.MainActivity.instancia;

public class themeHelper extends AppCompatActivity {
    Configuration configuration;

    public themeHelper() {
    }

    public void cambiarTema(String temaACambiar){
        int ui = getUI();
        int currentNightMode = ui & Configuration.UI_MODE_NIGHT_MASK;

        //Comprobar tema actual
        /*switch (currentNightMode) {
            case Configuration.UI_MODE_NIGHT_NO:
                Toast.makeText(this, getString(R.string.text_theme_already_changed), Toast.LENGTH_SHORT).show();
                break;
            case Configuration.UI_MODE_NIGHT_YES:
                // Cambiar a tema claro
                AppCompatDelegate.setDefaultNightMode(AppCompatDelegate.MODE_NIGHT_NO);
                Toast.makeText(this, getString(R.string.text_theme_changed_light), Toast.LENGTH_SHORT).show();
                MainActivity.instancia.recreate();

                break;
        }*/

        if(currentNightMode == Configuration.UI_MODE_NIGHT_NO)
        {
            if(temaACambiar.equals("oscuro"))
            {
                AppCompatDelegate.setDefaultNightMode(AppCompatDelegate.MODE_NIGHT_YES);
                Toast.makeText(this, getString(R.string.text_theme_changed_dark), Toast.LENGTH_SHORT).show();
                instancia.recreate();
            }
            else
            {
                Toast.makeText(this, getString(R.string.text_theme_already_changed), Toast.LENGTH_SHORT).show();
            }
        } else
        if(currentNightMode == Configuration.UI_MODE_NIGHT_YES)
        {
            if(temaACambiar.equals("claro"))
            {
                AppCompatDelegate.setDefaultNightMode(AppCompatDelegate.MODE_NIGHT_NO);
                Toast.makeText(this, getString(R.string.text_theme_changed_light), Toast.LENGTH_SHORT).show();
                instancia.recreate();
            }
            else
            {
                Toast.makeText(this, getString(R.string.text_theme_already_changed), Toast.LENGTH_SHORT).show();
            }
        }

    }

    private Configuration getConfiguration(){

        if (configuration == null) {
            configuration = instancia.getResources().getConfiguration();
        }
        return configuration;
    }

    public int getUI(){
        return getConfiguration().uiMode;
    }
}


