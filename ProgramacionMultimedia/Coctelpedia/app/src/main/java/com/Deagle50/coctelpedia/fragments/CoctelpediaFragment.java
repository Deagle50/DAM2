package com.deagle50.coctelpedia.fragments;

import android.database.Cursor;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.CheckBox;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;


import com.Deagle50.coctelpedia.fragments.CoctelesAdapter;
import com.deagle50.coctelpedia.Coctel;
import com.deagle50.coctelpedia.helpers.CoctelsOpenHelper;

import com.deagle50.coctelpedia.R;


import java.util.ArrayList;
public class CoctelpediaFragment extends Fragment implements View.OnClickListener {
    private RecyclerView recyclerView;
    private LinearLayoutManager linearLayoutManager = new LinearLayoutManager(getContext());
    private CoctelsOpenHelper coctelsOpenHelper;
    private Cursor cursorCoctels;
    private ArrayList<Coctel> coctels;
    private String selection = "", orderBy="";
    private ArrayList<String> whereArguments;

    private CheckBox cbVegetarian, cbVegan;
    public CoctelpediaFragment(){

    }

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {

        View view = inflater.inflate(R.layout.fragment_coctelpedia, container, false);

        coctelsOpenHelper = new CoctelsOpenHelper(getContext(), "cursorCoctels", null, 1);

        recyclerView = view.findViewById(R.id.RecyclerViewCoctel);
        recyclerView.setLayoutManager(linearLayoutManager);

        whereArguments = new ArrayList<>();

        cbVegetarian = view.findViewById(R.id.checkBoxVegetarian2);
        cbVegan = view.findViewById(R.id.checkBoxVegan2);
        cbVegetarian.setOnClickListener(this);
        cbVegan.setOnClickListener(this);

        initializeData();
        initializeAdapter();

        return view;
    }

    @Override
    public void onClick(View view) {
        whereArguments = new ArrayList<>();
        selection = "";
        orderBy = "";
        switch (view.getId())
        {
            case R.id.checkBoxVegetarian2:
            {
                if(cbVegetarian.isChecked())
                {
                    addSelection("vegetarian");
                    whereArguments.add("1");
                }
                else{
                    if(cbVegan.isChecked())
                    {
                        cbVegan.setChecked(false);
                    }
                }
                break;
            }
            case R.id.checkBoxVegan2:
            {
                if(cbVegan.isChecked())
                {
                    cbVegetarian.setChecked(true);
                    addSelection("vegan");
                    whereArguments.add("1");
                }
                else{
                    if(cbVegetarian.isChecked())
                    {
                        addSelection("vegetarian");
                        whereArguments.add("1");
                    }
                }
                break;
            }
        }
        initializeData();
        initializeAdapter();
    }
    private void initializeData(){
        cursorCoctels = coctelsOpenHelper.getCoctels(selection, whereArguments, orderBy);

        if(cursorCoctels!=null)
        {
            int i = 0;
            coctels = new ArrayList<>();
            while(cursorCoctels.moveToNext())
            {
                Coctel c = new Coctel(cursorCoctels.getString(1), cursorCoctels.getInt(2),
                                        cursorCoctels.getFloat(3), cursorCoctels.getFloat(4),
                                        cursorCoctels.getFloat(5), cursorCoctels.getString(6),
                                        cursorCoctels.getString(7), cursorCoctels.getInt(8)>0,
                                        cursorCoctels.getInt(9)>0, cursorCoctels.getString(10));
                coctels.add(i, c);
                i++;
            }
        }

        /*coctelList.add(new Coctel(1,"Gin-kas",
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
                "Se hace así 5" , "sabe así 5 asdn lkas kldjakdklasklasklasdklaklaskdaksdk ksksada asdasd asd asasd assda s s  kssk aksaskka"));*/
    }

    private void initializeAdapter(){
        CoctelesAdapter adapter = new CoctelesAdapter(coctels);
        recyclerView.setAdapter(adapter);
    }

    private void addSelection(String add){
        if(selection.equals(""))
        {
            selection=add+"=?";
        }
        else
            selection+=", "+add+"=?";
    }
}