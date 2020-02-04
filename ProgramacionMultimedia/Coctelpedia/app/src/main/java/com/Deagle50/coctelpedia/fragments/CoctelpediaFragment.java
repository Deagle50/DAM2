package com.deagle50.coctelpedia.fragments;

import android.database.Cursor;
import android.database.MatrixCursor;
import android.database.MergeCursor;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.CheckBox;
import android.widget.SimpleCursorAdapter;
import android.widget.Spinner;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.deagle50.coctelpedia.Coctel;
import com.deagle50.coctelpedia.helpers.CoctelsOpenHelper;

import com.deagle50.coctelpedia.R;


import java.util.ArrayList;
public class CoctelpediaFragment extends Fragment implements View.OnClickListener {
    private RecyclerView recyclerView;
    private LinearLayoutManager linearLayoutManager = new LinearLayoutManager(getContext());
    private CoctelsOpenHelper coctelsOpenHelper;

    private String selection = "", orderBy="";
    private ArrayList<Coctel> coctels;
    private ArrayList<String> whereArguments;

    private CheckBox cbVegetarian, cbVegan;
    private View view;

    private Spinner spinnerType;

    public CoctelpediaFragment(){

    }

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {

        view = inflater.inflate(R.layout.fragment_coctelpedia, container, false);

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

        initializeSpinnerOrderBy();
        initializeSpinnerType();

        return view;
    }

    @Override
    public void onClick(View view) {
        selection = "";

        switch (view.getId())
        {
            case R.id.checkBoxVegetarian2:
            {
            }
            case R.id.checkBoxVegan2:
            {
                addSelection();
                break;
            }
        }
        initializeData();
        initializeAdapter();
    }

    private void initializeData(){
        Cursor cursorCoctels;
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
    }

    private void initializeAdapter(){
        CoctelesAdapter adapter = new CoctelesAdapter(coctels);
        recyclerView.setAdapter(adapter);
    }

    private void initializeSpinnerOrderBy() {
        Spinner spinnerOrderBy = view.findViewById(R.id.spinnerOrderBy);
        // Create an ArrayAdapter using the string array and a default spinner layout
        ArrayAdapter<CharSequence> adapter = ArrayAdapter.createFromResource(getContext(),
                R.array.orderby, android.R.layout.simple_spinner_item);
        // Specify the layout to use when the list of choices appears
        adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        // Apply the adapter to the spinner
        spinnerOrderBy.setAdapter(adapter);


        spinnerOrderBy.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener()
        {
            public void onItemSelected(AdapterView<?> parent, View view, int position, long id)
            {
                switch((int)parent.getItemIdAtPosition(position))
                {
                    case 0:
                        orderBy = "";
                        break;
                    case 1:
                        orderBy ="name ASC";
                        break;
                    case 2:
                        orderBy = "name DESC";
                        break;
                    case 3:
                        orderBy = "priceH ASC";
                        break;
                    case 4:
                        orderBy = "priceH DESC";
                        break;
                    case 5:
                        orderBy = "priceB ASC";
                        break;
                    case 6:
                        orderBy = "priceB DESC";
                        break;
                    case 7:
                        orderBy = "type ASC";
                        break;
                    case 8:
                        orderBy = "type DESC";
                        break;
                    case 9:
                        orderBy = "graduation ASC";
                        break;
                    case 10:
                        orderBy = "graduation DESC";
                        break;

                }
                initializeData();
                initializeAdapter();

            } // to close the onItemSelected
            public void onNothingSelected(AdapterView<?> parent)
            {

            }
        });

    }

    private void initializeSpinnerType() {
        SimpleCursorAdapter adapter;
        String[] from = new String[]{"type"};
        int[] to = new int[]{android.R.id.text1};

        Cursor cursorTypes = coctelsOpenHelper.getTypes();

        //Add "All" option to the spinner
        MatrixCursor matrixCursor = new MatrixCursor(new String[] { "_id", "type"});
        matrixCursor.addRow(new Object[] { "0", getString(R.string.title_all_drinks) });

        MergeCursor mergeCursor = new MergeCursor(new Cursor[] { matrixCursor, cursorTypes });

        spinnerType = view.findViewById(R.id.spinnerDrinkType);
        // Create an ArrayAdapter using the string array and a default spinner layout

        adapter = new SimpleCursorAdapter(getContext(), android.R.layout.simple_spinner_item, mergeCursor, from, to,0);
        adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        spinnerType.setAdapter(adapter);
        // Specify the layout to use when the list of choices appears
        adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        // Apply the adapter to the spinner
        spinnerType.setAdapter(adapter);


        spinnerType.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener()
        {
            public void onItemSelected(AdapterView<?> parent, View view, int position, long id)
            {
                addSelection();
                initializeData();
                initializeAdapter();
            }
            public void onNothingSelected(AdapterView<?> parent)
            {
            }
        });

    }



    private void addSelection(){
        whereArguments = new ArrayList<>();
        String add="";
        String add2="";

        if(!cbVegetarian.isChecked() && cbVegan.isChecked() || cbVegetarian.isChecked() && cbVegan.isChecked())
        {
            cbVegetarian.setChecked(true);
            add = "vegan=?";
            whereArguments.add("1");
        }
        else if(cbVegetarian.isChecked() && !cbVegan.isChecked())
        {
            add = "vegetarian=?";
            whereArguments.add("1");
        }

        selection = add;

        String selectedItem = spinnerType.getSelectedItem().toString();
        if(selectedItem.equals(getString(R.string.title_all_drinks)))
        {

        }
        else{
            if(selection.equals(""))
            {
                add2="type=?";
                whereArguments.add(selectedItem);
                selection=add2;
            }
            else
            {
                add2="AND type=?";
                whereArguments.add(selectedItem);
                selection+=add2;
            }

        }


    }


}