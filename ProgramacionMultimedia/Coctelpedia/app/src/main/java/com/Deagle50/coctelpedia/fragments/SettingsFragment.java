package com.deagle50.coctelpedia.fragments;


import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AlertDialog;
import androidx.fragment.app.Fragment;

import com.deagle50.coctelpedia.helpers.languageHelper;
import com.deagle50.coctelpedia.R;
import com.deagle50.coctelpedia.helpers.themeHelper;

import static com.deagle50.coctelpedia.activities.MainActivity.instance;

public class SettingsFragment extends Fragment implements View.OnClickListener {
    private Button buttonES, buttonEU, buttonEN;
    private Button buttonGmail1, buttonGmail2;
    private Button buttonDark, buttonLight;
    private TextView tvBug, tvNTrans, tvTransIssue, tvEmail;
    private TextView tvCredits;
    private View root;

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {

        root = inflater.inflate(R.layout.fragment_settings, container, false);

        buttonGmail1 = root.findViewById(R.id.buttonGmail1);
        buttonGmail2 = root.findViewById(R.id.buttonGmail2);
        tvEmail = root.findViewById(R.id.textViewCorreo);
        buttonGmail1.setOnClickListener(this);
        buttonGmail2.setOnClickListener(this);
        tvEmail.setOnClickListener(this);

        buttonES = root.findViewById(R.id.buttonES);
        buttonEU = root.findViewById(R.id.buttonEU);
        buttonEN = root.findViewById(R.id.buttonEN);
        buttonES.setOnClickListener(this);
        buttonEU.setOnClickListener(this);
        buttonEN.setOnClickListener(this);

        tvBug = root.findViewById(R.id.textViewBugs);
        tvNTrans = root.findViewById(R.id.textViewNewTranslation);
        tvTransIssue = root.findViewById(R.id.textViewTranslationIssue);
        tvBug.setOnClickListener(this);
        tvTransIssue.setOnClickListener(this);
        tvNTrans.setOnClickListener(this);

        buttonDark = root.findViewById(R.id.buttonDarkTheme);
        buttonLight = root.findViewById(R.id.buttonLightTheme);
        buttonDark.setOnClickListener(this);
        buttonLight.setOnClickListener(this);

        tvCredits = root.findViewById(R.id.textViewCredits);
        tvCredits.setOnClickListener(this);

        return root;
    }

    @Override
    public void onClick(View v) {
        String asunto="";
        switch(v.getId()){
            //IDIOMAS
            case R.id.buttonES:{
                cambiarIdioma("es");
                break;
            }
            case R.id.buttonEN:{
                cambiarIdioma("en");
                break;
            }
            case R.id.buttonEU:{
                cambiarIdioma("eu");
                break;
            }
            //FEEDBACK
            case R.id.textViewBugs:
            {
                asunto = getString(R.string.title_bugs);
                break;
            }
            case R.id.textViewNewTranslation:{
                asunto = getString(R.string.title_new_translation);
                break;
            }
            case R.id.textViewTranslationIssue:{
                asunto = getString(R.string.title_translation_issue);
                break;
            }
            //CONTACTO
            case R.id.buttonGmail1:{}

            case R.id.buttonGmail2:{}

            case R.id.textViewCorreo:{
                Intent intent = new Intent(Intent.ACTION_SEND);
                String[] emails_in_to={"urkourbieta@gmail.com"};
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
                cambiarTema("claro");
                break;
            }
            case R.id.buttonDarkTheme:{
                cambiarTema("oscuro");
                break;
            }
            case R.id.textViewCredits:{
                AlertDialog.Builder alertDialogBuilder = new AlertDialog.Builder(
                        getContext());

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
            }


            break;

        }
        //Enviar email
        if(v== tvBug||v==tvNTrans||v==tvTransIssue)
        {
            Intent intent = new Intent(Intent.ACTION_SEND);
            String[] emails_in_to={"urkourbieta@gmail.com"};
            intent.putExtra(Intent.EXTRA_EMAIL, emails_in_to );
            intent.putExtra(Intent.EXTRA_SUBJECT,asunto);
            intent.putExtra(Intent.EXTRA_TEXT, "");
            intent.setType("text/html");
            intent.setPackage("com.google.android.gm");
            startActivity(intent);
        }
    }

    private void cambiarIdioma(String lg) {
        languageHelper lh = new languageHelper(getContext());
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

            themeHelper th = new themeHelper(getContext());
            if(th.isDark()) {
                th.changeTheme("claro");
                th.changeTheme("oscuro");
                th.saveTheme();
            }
            else
            {
                th.changeTheme("oscuro");
                th.changeTheme("claro");
                th.saveTheme();
            }

            //Fin ñapa suprema

        }
        else
        {
            Toast.makeText(instance,R.string.text_language_already_changed, Toast.LENGTH_SHORT);
        }


    }

    private void cambiarTema(String theme)
    {
        themeHelper th = new themeHelper(getContext());
        th.changeTheme(theme);
        th.saveTheme();
    }

}