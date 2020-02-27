package com.deagle50.coctelpaedia.fragments;


import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AlertDialog;
import androidx.fragment.app.Fragment;

import com.deagle50.coctelpaedia.R;
import com.deagle50.coctelpaedia.helpers.LanguageHelper;
import com.deagle50.coctelpaedia.helpers.ThemeHelper;
import com.google.android.gms.ads.AdRequest;
import com.google.android.gms.ads.InterstitialAd;

import java.util.Objects;

import static com.deagle50.coctelpaedia.activities.MainActivity.instance;

public class SettingsFragment extends Fragment implements View.OnClickListener {

    private TextView tvBug;
    private TextView tvNTrans;
    private TextView tvTransIssue;
    private InterstitialAd interstitialAd;

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {

        View root = inflater.inflate(R.layout.fragment_settings, container, false);

        Button buttonGmail1 = root.findViewById(R.id.buttonGmail1);
        Button buttonGmail2 = root.findViewById(R.id.buttonGmail2);
        TextView tvEmail = root.findViewById(R.id.textViewCorreo);
        buttonGmail1.setOnClickListener(this);
        buttonGmail2.setOnClickListener(this);
        tvEmail.setOnClickListener(this);

        Button buttonES = root.findViewById(R.id.buttonES);
        Button buttonEU = root.findViewById(R.id.buttonEU);
        Button buttonEN = root.findViewById(R.id.buttonEN);
        buttonES.setOnClickListener(this);
        buttonEU.setOnClickListener(this);
        buttonEN.setOnClickListener(this);

        tvBug = root.findViewById(R.id.textViewBugs);
        tvNTrans = root.findViewById(R.id.textViewNewTranslation);
        tvTransIssue = root.findViewById(R.id.textViewTranslationIssue);
        TextView tvSupport = root.findViewById(R.id.textViewSupport);
        tvBug.setOnClickListener(this);
        tvTransIssue.setOnClickListener(this);
        tvNTrans.setOnClickListener(this);
        tvSupport.setOnClickListener(this);

        Button buttonDark = root.findViewById(R.id.buttonDarkTheme);
        Button buttonLight = root.findViewById(R.id.buttonLightTheme);
        buttonDark.setOnClickListener(this);
        buttonLight.setOnClickListener(this);

        TextView tvCredits = root.findViewById(R.id.textViewCredits);
        tvCredits.setOnClickListener(this);

        interstitialAd = new InterstitialAd(Objects.requireNonNull(getContext()));
        interstitialAd.setAdUnitId("ca-app-pub-3940256099942544/1033173712");
        interstitialAd.loadAd(new AdRequest.Builder().build());

        /*
        * My ad id:     ca-app-pub-5556606541783481/4504898555
        * Google ad id: ca-app-pub-3940256099942544/1033173712
        * */

        return root;
    }

    @Override
    public void onClick(View v) {
        String subject="";
        switch(v.getId()){
            //LANGUAGES
            case R.id.buttonES:{
                changeLanguage("es");
                break;
            }
            case R.id.buttonEN:{
                changeLanguage("en");
                break;
            }
            case R.id.buttonEU:{
                changeLanguage("eu");
                break;
            }
            //FEEDBACK
            case R.id.textViewBugs:
            {
                subject = getString(R.string.title_bugs);
                break;
            }
            case R.id.textViewNewTranslation:{
                subject = getString(R.string.title_new_translation);
                break;
            }
            case R.id.textViewTranslationIssue:{
                subject = getString(R.string.title_translation_issue);
                break;
            }
            //CONTACT
            case R.id.buttonGmail1:{}

            case R.id.buttonGmail2:{}

            case R.id.textViewCorreo:{
                Intent intent = new Intent(Intent.ACTION_SEND);
                String[] emails_in_to={getString(R.string.email)};
                intent.putExtra(Intent.EXTRA_EMAIL, emails_in_to );
                intent.putExtra(Intent.EXTRA_SUBJECT,"Asunto");
                intent.putExtra(Intent.EXTRA_TEXT, "Texto");
                intent.setType("text/html");
                intent.setPackage("com.google.android.gm");
                startActivity(intent);
                break;
            }
            //CAMBIAR TEMA
            case R.id.buttonLightTheme:{
                changeTheme("light");
                break;
            }
            case R.id.buttonDarkTheme:{
                changeTheme("dark");
                break;
            }
            case R.id.textViewCredits:{
                AlertDialog.Builder alertDialogBuilder = new AlertDialog.Builder(
                        Objects.requireNonNull(getContext()));

                // set title
                alertDialogBuilder.setTitle(R.string.title_credits);

                // set dialog message
                alertDialogBuilder
                        .setMessage(R.string.text_credits)
                        .setCancelable(false)
                        .setNeutralButton(R.string.title_close,new DialogInterface.OnClickListener() {
                            public void onClick(DialogInterface dialog,int id) {
                                // if this button is clicked

                            }
                        });
                // create alert dialog
                AlertDialog alertDialog = alertDialogBuilder.create();
                // show it
                alertDialog.show();
                break;
            }

            case R.id.textViewSupport:
            {
                if (interstitialAd.isLoaded()) {
                    interstitialAd.show();
                } else {
                    Log.d("TAG", "The interstitial wasn't loaded yet.");
                    Toast.makeText(getContext(), getString(R.string.title_no_ads), Toast.LENGTH_SHORT).show();
                }
            }
        }


        //Send email
        if(v== tvBug||v==tvNTrans||v==tvTransIssue)
        {
            Intent intent = new Intent(Intent.ACTION_SEND);
            String[] emails_in_to={getString(R.string.email)};
            intent.putExtra(Intent.EXTRA_EMAIL, emails_in_to );
            intent.putExtra(Intent.EXTRA_SUBJECT,subject);
            intent.putExtra(Intent.EXTRA_TEXT, "");
            intent.setType("text/html");
            intent.setPackage("com.google.android.gm");
            startActivity(intent);
        }
    }

    private void changeLanguage(String lg) {
        LanguageHelper lh = new LanguageHelper(Objects.requireNonNull(getContext()));
        if(!lh.getLanguage(getContext()).equals(lg))
        {
            lh.setLocale(instance, lg);
            lh.saveLanguage(instance, lg);

            /* ÑAPA SUPREMA
             *
             * No sé por qué, el idioma solo se cambia si cambias también el tema
             * Así que cambio dos veces el tema (así se queda en el mismo)
             * para que se quede en el tema escogido con el idioma cambiado
             *
             */

            ThemeHelper th = new ThemeHelper(getContext());
            if(th.isDark()) {
                th.changeTheme("light");
                th.changeTheme("dark");
                th.saveTheme();
            }
            else
            {
                th.changeTheme("dark");
                th.changeTheme("light");
                th.saveTheme();
            }

            //Fin ñapa suprema

        }


    }

    private void changeTheme(String theme)
    {
        ThemeHelper th = new ThemeHelper(Objects.requireNonNull(getContext()));
        th.changeTheme(theme);
        th.saveTheme();
    }

}