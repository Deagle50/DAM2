package com.deagle50.coctelpaedia.helpers;

import android.annotation.TargetApi;
import android.content.Context;
import android.content.SharedPreferences;
import android.content.res.Configuration;
import android.os.Build;

import com.deagle50.coctelpaedia.R;

import java.util.Locale;

public class LanguageHelper {
    private Context context;
    private String savedLanguage;
    private static final String SELECTED_LANGUAGE = "Locale.Helper.Selected.Language";

    public LanguageHelper(Context context) {
        this.context = context;
        SharedPreferences shp = context.getSharedPreferences(context.getResources().getString(R.string.preferences_language_file), Context.MODE_PRIVATE);
        savedLanguage = shp.getString(context.getResources().getString(R.string.preferences_language), "es");
    }

    public String getLanguage(Context context) {

        SharedPreferences shp = context.getSharedPreferences(context.getResources().getString(R.string.preferences_language_file), Context.MODE_PRIVATE);
        return shp.getString(SELECTED_LANGUAGE, "");
        //return getPersistedData(context, Locale.getDefault().getLanguage());
    }

    public Context setLocale(Context context, String language) {
        persist(context, language);

        if(!getLanguage(context).equals(language)) {

            return updateResources(context, language);
        }
        return updateResources(context, getLanguage(context));
    }

    private void persist(Context context, String language) {
        SharedPreferences preferences = context.getSharedPreferences(context.getResources().getString(R.string.preferences_language_file), Context.MODE_PRIVATE);
        SharedPreferences.Editor editor = preferences.edit();

        editor.putString(SELECTED_LANGUAGE, language);
        editor.apply();
    }

    @TargetApi(Build.VERSION_CODES.N)
    private Context updateResources(Context context, String language) {
        Locale locale = new Locale(language);
        Locale.setDefault(locale);

        Configuration configuration = context.getResources().getConfiguration();
        configuration.setLocale(locale);

        return context.createConfigurationContext(configuration);
    }

    public void saveLanguage(Context context, String leng){
        SharedPreferences shp = context.getSharedPreferences(context.getResources().getString(R.string.preferences_language_file), Context.MODE_PRIVATE);
        SharedPreferences.Editor editor = shp.edit();

        editor.putString(context.getResources().getString(R.string.preferences_language), leng);
        editor.apply();
    }

    public void loadSavedLanguage(Context context) {
        //Cargar lenguaje al iniciar activity
        //SharedPreferences shp = context.getSharedPreferences(context.getResources().getString(R.string.preferences_language_file), Context.MODE_PRIVATE);
        //String currLanguage = shp.getString(context.getResources().getString(R.string.preferences_language), Locale.getDefault().getLanguage());
        setLocale(context, getLanguage(context));
    }

}
