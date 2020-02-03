package com.deagle50.coctelpedia.helpers;

import android.annotation.TargetApi;
import android.content.Context;
import android.content.SharedPreferences;
import android.content.res.Configuration;
import android.content.res.Resources;
import android.os.Build;
import android.preference.PreferenceManager;

import com.deagle50.coctelpedia.R;

import java.util.Locale;

import static com.deagle50.coctelpedia.activities.MainActivity.instancia;

public class languageHelper {
    private Context context;
    private String savedLanguage;
    private static final String SELECTED_LANGUAGE = "Locale.Helper.Selected.Language";

    public languageHelper(Context context) {
        this.context = context;
        SharedPreferences shp = context.getSharedPreferences(context.getResources().getString(R.string.preferences_language_file), Context.MODE_PRIVATE);
        savedLanguage = shp.getString(context.getResources().getString(R.string.preferences_language), "es");
    }

    /*public static Context onAttach(Context context) {
        String lang = getPersistedData(context, Locale.getDefault().getLanguage());
        return setLocale(context, lang);
    }

    public static Context onAttach(Context context, String defaultLanguage) {
        String lang = getPersistedData(context, defaultLanguage);
        return setLocale(context, lang);
    }*/

    public String getLanguage(Context context) {
        return getPersistedData(context, Locale.getDefault().getLanguage());
    }

    public Context setLocale(Context context, String language) {
        persist(context, language);

        if(!getLanguage(context).equals(language)) {

            return updateResources(context, language);
        }
        return updateResources(context, getLanguage(context));
    }

    private String getPersistedData(Context context, String defaultLanguage) {
        SharedPreferences preferences = PreferenceManager.getDefaultSharedPreferences(context);
        return preferences.getString(SELECTED_LANGUAGE, defaultLanguage);
    }

    private void persist(Context context, String language) {
        SharedPreferences preferences = PreferenceManager.getDefaultSharedPreferences(context);
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
        SharedPreferences shp = context.getSharedPreferences(context.getResources().getString(R.string.preferences_language_file), context.MODE_PRIVATE);
        SharedPreferences.Editor editor = shp.edit();

        editor.putString(context.getResources().getString(R.string.preferences_language), leng);

        editor.commit();
    }

    public void loadSavedLanguage(Context context) {
        //Cargar lenguaje al iniciar activity
        SharedPreferences shp = context.getSharedPreferences(context.getResources().getString(R.string.preferences_language_file), context.MODE_PRIVATE);
        String currLanguage = shp.getString(context.getResources().getString(R.string.preferences_language), "es");
        setLocale(context, currLanguage);


    }

}
