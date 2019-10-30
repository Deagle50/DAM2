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
import androidx.fragment.app.Fragment;

public class Fragment2 extends Fragment implements View.OnClickListener {
    ViewGroup container;

    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        this.container=container;
        LinearLayout layout=(LinearLayout) inflater.inflate(R.layout.layout_fragment2,null);
        ImageView img = layout.findViewById(R.id.imageView);
        img.setImageDrawable(getResources().getDrawable(R.drawable.bocadillo,null));
        return layout;
    }

    @Override
    public void onClick(View v) {
        Intent i = new Intent(getActivity(),Main2Activity.class);
        getActivity().startActivity(i);
    }
}
