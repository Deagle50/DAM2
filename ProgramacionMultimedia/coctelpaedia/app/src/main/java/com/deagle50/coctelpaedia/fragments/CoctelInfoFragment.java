package com.deagle50.coctelpaedia.fragments;

import android.annotation.SuppressLint;
import android.app.Fragment;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.CheckBox;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.constraintlayout.widget.ConstraintLayout;

import com.deagle50.coctelpaedia.Coctel;
import com.deagle50.coctelpaedia.R;

import eightbitlab.com.blurview.BlurView;
import eightbitlab.com.blurview.RenderScriptBlur;

@SuppressWarnings("ALL")
public class CoctelInfoFragment extends Fragment implements View.OnClickListener {
    private Coctel coctel;
    private View view;
    private ConstraintLayout constraintLayoutBackground;

    private TextView tvDescription;
    private TextView tvMaking;
    private TextView tvDescriptionClick, tvMakingClick;

    @SuppressLint("ValidFragment")
    public CoctelInfoFragment(Coctel coctel) {
        this.coctel = coctel;
    }

    public CoctelInfoFragment(){

    }

    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        view = inflater.inflate(R.layout.fragment_coctel_info, container, false);

        loadCoctel();

        loadBlur();

        return view;
    }

    @Override
    public void onClick(View v) {
        if(v==tvDescriptionClick)
        {
            if(tvDescription.getVisibility()==View.GONE)
            {
                tvDescription.setVisibility(View.VISIBLE);
                tvDescriptionClick.setText(getContext().getResources().getString(R.string.title_description_close));
            }
            else
            {
                tvDescription.setVisibility(View.GONE);
                tvDescriptionClick.setText(getContext().getResources().getString(R.string.title_description_open));
            }
        }
        if(v==tvMakingClick)
        {
            if(tvMaking.getVisibility()==View.GONE)
            {
                tvMaking.setVisibility(View.VISIBLE);
                tvMakingClick.setText(getContext().getResources().getString(R.string.title_making_close));
            }
            else
            {
                tvMaking.setVisibility(View.GONE);
                tvMakingClick.setText(getContext().getResources().getString(R.string.title_making_open));
            }
        }
        else if(v== constraintLayoutBackground)
        {
            getActivity().getFragmentManager().beginTransaction().remove(this).commit();
        }
    }

    @Override
    public void onStop() {
        super.onStop();
        getActivity().getFragmentManager().beginTransaction().remove(this).commitAllowingStateLoss();
    }

    @Override
    public void onDetach() {
        super.onDetach();
        getActivity().getFragmentManager().beginTransaction().remove(this).commitAllowingStateLoss();
    }

    @SuppressLint("ClickableViewAccessibility")
    private void loadCoctel() {
        TextView tvName, tvType, tvGraduation, tvBar, tvHome;
        ImageView imageView;
        CheckBox cbVegetarian, cbVegan;

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
        tvType.setText(coctel.getType());
        tvGraduation.setText(String.format("%s º", coctel.getGraduation().toString()));
        tvDescription.setText(coctel.getDescription());
        tvMaking.setText(coctel.getElaboration());
        tvBar.setText(String.format("%s €", coctel.getPriceB().toString()));
        tvHome.setText(String.format("%s €", coctel.getPriceH().toString()));

        constraintLayoutBackground = view.findViewById(R.id.clCoctelInfo);
        constraintLayoutBackground.setOnClickListener(this);
        tvDescriptionClick = view.findViewById(R.id.textViewDescription1Info);
        tvDescriptionClick.setOnClickListener(this);
        tvMakingClick = view.findViewById(R.id.textViewMaking1Info);
        tvMakingClick.setOnClickListener(this);

        if(coctel.isVegan())
        {
            cbVegan.setChecked(true);
            cbVegetarian.setChecked(true);
        }
        else if(coctel.isVegetarian())
        {
            cbVegetarian.setChecked(true);
            cbVegan.setChecked(false);
        }

        if(coctel.getUrlPhoto()==1)
        {
            //If urlPhoto is empty load default photo
            imageView.setImageResource(R.drawable.coctel);
        }
        else{
            imageView.setImageResource(coctel.getUrlPhoto());
        }
    }

    private void loadBlur() {
        BlurView blurView;
        //Apply blur on background to set this fragment as important
        blurView = view.findViewById(R.id.blurViewCoctelInfo);

        //Change this value to set different blur emphasis
        float radius = 3f;

        View decorView = getActivity().getWindow().getDecorView();
        ViewGroup rootView = decorView.findViewById(android.R.id.content);
        Drawable windowBackground = decorView.getBackground();

        blurView.setupWith(rootView)
                .setFrameClearDrawable(windowBackground)
                .setBlurAlgorithm(new RenderScriptBlur(getContext()))
                .setBlurRadius(radius)
                .setHasFixedTransformationMatrix(true);
    }


}
