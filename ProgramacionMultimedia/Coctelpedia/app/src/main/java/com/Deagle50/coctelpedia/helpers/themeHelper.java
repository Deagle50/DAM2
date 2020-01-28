package com.deagle50.coctelpedia.helpers;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.content.res.Configuration;
import android.graphics.Bitmap;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.drawable.Drawable;
import android.os.Build;
import android.text.Spannable;
import android.text.SpannableString;
import android.text.style.ForegroundColorSpan;
import android.view.LayoutInflater;
import android.view.View;
import android.widget.ImageView;
import android.widget.Toast;

import androidx.appcompat.app.ActionBar;
import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.app.AppCompatDelegate;
import androidx.core.content.ContextCompat;
import androidx.core.graphics.drawable.DrawableCompat;

import com.deagle50.coctelpedia.R;
import com.deagle50.coctelpedia.activities.MainActivity;

import static com.deagle50.coctelpedia.activities.MainActivity.instancia;

public class themeHelper extends AppCompatActivity {

    private Configuration configuration;
    private Context context;
    private Activity activity;
    private boolean savedThemeDark;

    public themeHelper(Context context)
    {
        this.context = context;
        SharedPreferences shp = context.getSharedPreferences(context.getResources().getString(R.string.preferences_theme_file), Context.MODE_PRIVATE);
        savedThemeDark = shp.getBoolean(context.getResources().getString(R.string.preferences_isdark), false);
    }

    public themeHelper(Context context, Activity activity)
    {
        this.activity = activity;
        this.context = context;
        SharedPreferences shp = context.getSharedPreferences(context.getResources().getString(R.string.preferences_theme_file), Context.MODE_PRIVATE);
        savedThemeDark = shp.getBoolean(context.getResources().getString(R.string.preferences_isdark), false);
    }

    public void changeTheme(String temaACambiar){

        //Cambiar tema
            if(temaACambiar.equals("oscuro"))//Si el tema a cambiar es el oscuro
            {
                //Comprobar si el tema actual es oscuro
                if(!isDark())
                {
                    loadDark();
                }else {
                //Si ya está en oscuro
                }
            } else//Si el tema a cambiar es al claro
            if(temaACambiar.equals("claro"))
            {
                if(isDark())//Comprobar si el tema actual es oscuro
                {
                    loadLight();
                }//Si ya está en claro
                else{

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
        //Devuelve true si el modo actual es el oscuro
        int ui = getUI();
        int currentNightMode = ui & Configuration.UI_MODE_NIGHT_MASK;
        if(currentNightMode == Configuration.UI_MODE_NIGHT_YES)
        {
            return true;
        }
        return false;
    }

    public void saveTheme(){
        SharedPreferences shp = context.getSharedPreferences(context.getResources().getString(R.string.preferences_theme_file), context.MODE_PRIVATE);
        SharedPreferences.Editor editor = shp.edit();
        if(isDark()) {
            editor.putBoolean(context.getResources().getString(R.string.preferences_isdark), true);
        }
        else {
            editor.putBoolean(context.getResources().getString(R.string.preferences_isdark), false);
        }
        editor.commit();
    }

    public void loadDark(){
        //AÑADIR, CAMBIAR FOTO IMAGEN PRINCIPAL
        AppCompatDelegate.setDefaultNightMode(AppCompatDelegate.MODE_NIGHT_YES);

        //Cambiar color texto actionbar


        instancia.recreate();

        /*ActionBar ab = instancia.getSupportActionBar();
        Spannable text = new SpannableString(ab.getTitle());
        text.setSpan(new ForegroundColorSpan(instancia.getResources().getColor(R.color.fontWhite, null)), 0, text.length(), Spannable.SPAN_INCLUSIVE_INCLUSIVE);
        ab.setTitle(text);*/
    }

    public void loadLight(){
        //AÑADIR CAMBIAR FOTO IMAGEN PRINCIPAL, CAMBIAR COLOR TEXTO ACTIONBAR
        AppCompatDelegate.setDefaultNightMode(AppCompatDelegate.MODE_NIGHT_NO);

        //Cambiar color texto actionbar
        instancia.recreate();

        /*ActionBar ab = instancia.getSupportActionBar();
        Spannable text = new SpannableString(ab.getTitle());
        text.setSpan(new ForegroundColorSpan(Color.RED), 0, text.length(), Spannable.SPAN_INCLUSIVE_INCLUSIVE);
        ab.setTitle(text);*/
    }

    public void loadSavedTheme() {
        //Cargar modo oscuro o no al iniciar activity
        if(savedThemeDark)
        {
            if(isDark()){
                //El tema ya es oscuro, no hace nada
            }
            else{
                loadDark();
            }
        }
        else
        {
            if(isDark())
            {
                loadLight();
            }
        }

    }

}


