package com.deagle50.coctelpedia.ui.settings;

import android.content.Intent;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;

import com.deagle50.coctelpedia.LanguageHelper;
import com.deagle50.coctelpedia.R;

public class SettingsFragment extends Fragment implements View.OnClickListener {
    Button buttonES, buttonEU, buttonEN;
    Button buttonGmail1, buttonGmail2;
    Button buttonDark, buttonLight;
    TextView tvBug, tvNTrans, tvTransIssue, tvCorreo;
    View root;

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {

        root = inflater.inflate(R.layout.fragment_settings, container, false);






        buttonGmail1 = root.findViewById(R.id.buttonGmail1);
        buttonGmail2 = root.findViewById(R.id.buttonGmail2);
        tvCorreo = root.findViewById(R.id.textViewCorreo);
        buttonGmail1.setOnClickListener(this);
        buttonGmail2.setOnClickListener(this);
        tvCorreo.setOnClickListener(this);

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
            case R.id.buttonGmail1:{

            }
            case R.id.buttonGmail2:{

            }
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
            case R.id.buttonDarkTheme:{
                Toast.makeText(getContext(), "Work in progres...", Toast.LENGTH_SHORT).show();
                break;
            }
            case R.id.buttonLightTheme:{
                Toast.makeText(getContext(), "Work in progress...", Toast.LENGTH_SHORT).show();
                break;
            }

        }
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
        LanguageHelper.setLocale(getContext(), lg);
        getActivity().recreate();
    }
}