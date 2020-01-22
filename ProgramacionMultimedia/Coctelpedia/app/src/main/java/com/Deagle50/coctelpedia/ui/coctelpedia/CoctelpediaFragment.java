package com.deagle50.coctelpedia.ui.coctelpedia;

import android.content.Context;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.deagle50.coctelpedia.Coctel;
import com.deagle50.coctelpedia.CoctelRecyclerViewAdapter;
import com.deagle50.coctelpedia.OnCoctelInteractionListener;
import com.deagle50.coctelpedia.R;

import java.util.ArrayList;
import java.util.List;

public class CoctelpediaFragment extends Fragment {
    OnCoctelInteractionListener mListener;
    List<Coctel> coctelList;

    public CoctelpediaFragment(){

    }

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {

        View view = inflater.inflate(R.layout.fragment_coctelpedia, container, false);

        // Set the adapter
        if (view instanceof RecyclerView) {
            Context context = view.getContext();
            RecyclerView recyclerView = (RecyclerView) view;
            recyclerView.setLayoutManager(new LinearLayoutManager(context));

            // Lista de averias
            coctelList = new ArrayList<>();
            coctelList.add(new Coctel(1,"Gin-kas",
                    "http://blog.mister-auto.es/wp-content/uploads/2014/09/23116650_m.jpg",
                    (float)37.5, (float)4, (float)7,"Se hace así" , "sabe así"));

            recyclerView.setAdapter(new CoctelRecyclerViewAdapter(getActivity(), coctelList, mListener));
        }
        return view;
    }

    @Override
    public void onAttach(Context context) {
        super.onAttach(context);
        if (context instanceof OnCoctelInteractionListener) {
            mListener = (OnCoctelInteractionListener) context;
        } else {
            throw new RuntimeException(context.toString()
                    + " must implement OnCoctelInteractionListener");
        }
    }

    @Override
    public void onDetach() {
        super.onDetach();
        mListener = null;
    }
}