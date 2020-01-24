package com.deagle50.coctelpedia.ui.coctelpedia;

import android.content.Context;
import android.os.Bundle;
import android.text.method.ScrollingMovementMethod;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;


import com.deagle50.coctelpedia.Coctel;

import com.deagle50.coctelpedia.CoctelesAdapter;
import com.deagle50.coctelpedia.R;


import java.util.ArrayList;
import java.util.List;

public class CoctelpediaFragment extends Fragment {
    RecyclerView rv;
    LinearLayoutManager llm = new LinearLayoutManager(getContext());
    TextView tvDescripcion;
    private List<Coctel> coctelList;

    public CoctelpediaFragment(){

    }

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {

        View view = inflater.inflate(R.layout.fragment_coctelpedia, container, false);

        rv = view.findViewById(R.id.RecyclerViewCoctel);
        rv.setLayoutManager(llm);

        initializeData();
        initializeAdapter();

        return view;
    }

    private void initializeData(){
        coctelList = new ArrayList<>();
        coctelList.add(new Coctel(1,"Gin-kas",
                "",//http://blog.mister-auto.es/wp-content/uploads/2014/09/23116650_m.jpg
                (float)37.5, (float)4, (float)7,
                "Se hace asísadddddddd sdsdsdsdsdsdsdsdsdsds dsdsdsdsdsd sdsdsdsdsdsdsdsdsdsdsd" +
                        " sdsdsdsdsdsdsdsdsdsdsdsdsd saddddsklad mlasskl malksk lalsk alsals" ,
                "sabe así asdjlkkkkkkkkkkkkkkkkkkkkkksad adsmklaaaaaaaaaaaa kasd klasmdkla klasmdkl asd a d ddddddddddddddd sddddd sajdklsa aksdlkl adsklad mlasskl malksk lalsk alsalsa\" +\n" +
                        "                        \"dsdsdsdsdsdsdsdsdsd sadddddddddddddddddd sddddd sajdklsa aksdlkl a", true, false));
        coctelList.add(new Coctel(2,"Gin-tonic",
                "",
                (float)38.5, (float)5, (float)8,
                "Se hace así 2" , "sabe así 2"));
        coctelList.add(new Coctel(3,"Ron cola",
                "",
                (float)35.5, (float)6, (float)9,
                "Se hace así 3" , "sabe así 3 asdn lkas kldjakdklasklasklasdklaklaskdaksdk ksksada asdasd asd asasd assda s s  kssk aksaskka", false, true));
        coctelList.add(new Coctel(4,"Kali",
                "",
                (float)13.5, (float)2, (float)3.5,
                "Se hace así 4" , "sabe así 4 asdn lkas kldjakdklasklasklasdklaklaskdaksdk ksksada asdasd asd asasd assda s s  kssk aksaskka"));
        coctelList.add(new Coctel(5,"Cerveza",
                "",
                (float)7.5, (float)1, (float)2.2,
                "Se hace así 5" , "sabe así 5 asdn lkas kldjakdklasklasklasdklaklaskdaksdk ksksada asdasd asd asasd assda s s  kssk aksaskka"));
    }

    private void initializeAdapter(){
        CoctelesAdapter adapter = new CoctelesAdapter(coctelList);
        rv.setAdapter(adapter);
    }


}