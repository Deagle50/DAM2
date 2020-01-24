package com.deagle50.coctelpedia.ui.settings;

import android.content.Intent;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;

import com.deagle50.coctelpedia.LanguageHelper;
import com.deagle50.coctelpedia.R;

public class SettingsFragment extends Fragment implements View.OnClickListener {
    Button buttonES, buttonEU, buttonEN, buttonGmail1, buttonGmail2;
    View root;

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {

        root = inflater.inflate(R.layout.fragment_settings, container, false);

        buttonES = root.findViewById(R.id.buttonES);
        buttonEU = root.findViewById(R.id.buttonEU);
        buttonEN = root.findViewById(R.id.buttonEN);
        buttonGmail1 = root.findViewById(R.id.buttonGmail1);
        buttonGmail2 = root.findViewById(R.id.buttonGmail2);

        buttonES.setOnClickListener(this);
        buttonEU.setOnClickListener(this);
        buttonEN.setOnClickListener(this);
        buttonGmail1.setOnClickListener(this);
        buttonGmail2.setOnClickListener(this);

        //////
        TextView txtI = root.findViewById(R.id.textViewIdiomaActual);
        txtI.setText(LanguageHelper.getLanguage(getContext()));

        return root;
    }

    @Override
    public void onClick(View v) {
        switch(v.getId()){
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
        }
        if(v== buttonGmail1||v==buttonGmail2)
        {
            Intent intent = new Intent(Intent.ACTION_SEND);
            String[] emails_in_to={"urkourbieta@gmail.com"};
            intent.putExtra(Intent.EXTRA_EMAIL, emails_in_to );
            intent.putExtra(Intent.EXTRA_SUBJECT,"Asunto");
            intent.putExtra(Intent.EXTRA_TEXT, "Texto");
            intent.setType("text/html");
            intent.setPackage("com.google.android.gm");
            startActivity(intent);
        }
    }

    private void cambiarIdioma(String lg) {
        LanguageHelper.setLocale(getContext(), lg);
        getActivity().recreate();
    }

    public void enviarPedirTraduccion(View v)
    {

    }
}