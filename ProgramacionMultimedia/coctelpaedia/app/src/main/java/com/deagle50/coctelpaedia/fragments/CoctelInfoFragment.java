package com.deagle50.coctelpaedia.fragments;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.CheckBox;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;

import com.deagle50.coctelpaedia.Coctel;
import com.deagle50.coctelpaedia.R;

public class CoctelInfoFragment extends Fragment {
    private Coctel coctel;
    private View view;

    private TextView tvName, tvType, tvGraduation, tvDescription, tvMaking, tvBar, tvHome;
    private CheckBox cbVegan, cbVegetarian;
    private ImageView imageView;

    public CoctelInfoFragment(Coctel coctel) {
        this.coctel = coctel;
    }

    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        view = inflater.inflate(R.layout.fragment_coctel_info, container, false);

        tvName = view.findViewById(R.id.textViewNameInfo);
        tvType = view.findViewById(R.id.textViewTypeInfo);
        tvGraduation = view.findViewById(R.id.textViewGraduationInfo);
        tvDescription = view.findViewById(R.id.textViewDescription2Info);
        tvMaking = view.findViewById(R.id.textViewMaking2Info);
        tvBar = view.findViewById(R.id.textViewPriceB2Info);
        tvHome = view.findViewById(R.id.textViewPriceH2Info);

        cbVegan = view.findViewById(R.id.checkBoxVeganInfo);
        cbVegetarian = view.findViewById(R.id.checkBoxVegetarianInfo);

        imageView = view.findViewById(R.id.imageViewCoctelInfo);

        tvName.setText(coctel.getName());

        return view;
    }
}
