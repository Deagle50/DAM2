package com.example.fragmentsactivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.LinearLayout;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.constraintlayout.widget.ConstraintLayout;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentManager;
import androidx.fragment.app.FragmentTransaction;

public class Fragment2 extends Fragment implements View.OnClickListener {
    ViewGroup container;

    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
    this.container=container;
        ConstraintLayout layout=(ConstraintLayout) inflater.inflate(R.layout.layout_fragment2,container,false);
        ImageView img=layout.findViewById(R.id.imageView);
        img.setImageDrawable(getResources().getDrawable(R.drawable.bocadillo,null));
        img.setOnClickListener(this);
        return layout;
    }

    @Override
    public void onClick(View v) {
       /* Intent i=new Intent(getActivity(),Main2Activity.class);
            getActivity().startActivity(i);*/
        FragmentManager fm=getActivity().getSupportFragmentManager();
        FragmentTransaction ft=fm.beginTransaction();
        ft.add(R.id.layout,new Fragment2());
        ft.addToBackStack(null);
        ft.commit();
    }
}
