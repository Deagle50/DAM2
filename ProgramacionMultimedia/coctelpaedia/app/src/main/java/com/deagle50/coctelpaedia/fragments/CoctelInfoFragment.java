package com.deagle50.coctelpaedia.fragments;

import android.annotation.SuppressLint;
import android.graphics.Bitmap;
import android.graphics.Canvas;
import android.os.Bundle;
import android.renderscript.RenderScript;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.ViewTreeObserver;
import android.widget.CheckBox;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.constraintlayout.widget.ConstraintLayout;
import androidx.fragment.app.FragmentTransaction;

import android.app.Fragment;

import com.deagle50.coctelpaedia.Coctel;
import com.deagle50.coctelpaedia.R;
import com.deagle50.coctelpaedia.extras.BlurCreator;

public class CoctelInfoFragment extends Fragment implements View.OnClickListener {
    private Coctel coctel;
    private View view;

    private ConstraintLayout constraintLayoutBackground;
    private ConstraintLayout constraintLayoutFront;

    private TextView tvName, tvType, tvGraduation, tvDescription, tvMaking, tvBar, tvHome;
    private TextView tvDescriptionClick, tvMakingClick;
    private CheckBox cbVegan, cbVegetarian;
    private ImageView imageView;



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

        return view;
    }

    @Override
    public void onViewCreated(View view, @Nullable Bundle savedInstanceState) {
        putBlur();
        super.onViewCreated(view, savedInstanceState);
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



    private void loadCoctel() {
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
        tvGraduation.setText(coctel.getGraduation().toString()+" º");
        tvDescription.setText(coctel.getDescription());
        tvMaking.setText(coctel.getElaboration());
        tvBar.setText(coctel.getPriceB().toString() + " €");
        tvHome.setText(coctel.getPriceH().toString() + " €");

        constraintLayoutBackground = view.findViewById(R.id.clCoctelInfo);
        constraintLayoutBackground.setOnClickListener(this);

        constraintLayoutFront = view.findViewById(R.id.cvCoctelInfoFront);

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

    private void putBlur() {
        /*RenderScript renderScript = RenderScript.create(getContext());
        new BlurCreator(renderScript).blur(getBitmapFromView(constraintLayoutBackground), 15, 1);*/
    }

    private static Bitmap getBitmapFromView(View view) {

        Bitmap bitmap = Bitmap.createBitmap(view.getWidth(), view.getHeight(), Bitmap.Config.ARGB_8888);
        Canvas c = new Canvas(bitmap);
        view.layout(view.getLeft(), view.getTop(), view.getRight(), view.getBottom());
        view.draw(c);
        return bitmap;
    }

}
