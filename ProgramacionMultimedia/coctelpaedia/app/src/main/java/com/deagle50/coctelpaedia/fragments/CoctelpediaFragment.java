package com.deagle50.coctelpaedia.fragments;

import android.database.Cursor;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.Spinner;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentTransaction;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.deagle50.coctelpaedia.Coctel;
import com.deagle50.coctelpaedia.R;
import com.deagle50.coctelpaedia.adapters.CoctelsAdapter;
import com.deagle50.coctelpaedia.helpers.CoctelsOpenHelper;

import java.util.ArrayList;
import java.util.Objects;

public class CoctelpediaFragment extends Fragment implements View.OnClickListener {
    private View view;
    private RecyclerView recyclerView;
    private LinearLayoutManager linearLayoutManager = new LinearLayoutManager(getContext());
    private Spinner spinnerType;
    private CheckBox cbVegetarian, cbVegan;
    private Button btnRandomDrink;

    private CoctelsOpenHelper coctelsOpenHelper;

    private String selection = "", orderBy="", spinnerText="";
    private ArrayList<String> whereArguments;
    private ArrayList<Coctel> coctels;


    public CoctelpediaFragment(){
    }

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {

        view = inflater.inflate(R.layout.fragment_coctelpedia, container, false);

        coctelsOpenHelper = new CoctelsOpenHelper(getContext());

        recyclerView = view.findViewById(R.id.RecyclerViewCoctel);
        recyclerView.setLayoutManager(linearLayoutManager);

        cbVegetarian = view.findViewById(R.id.checkBoxVegetarian2);
        cbVegan = view.findViewById(R.id.checkBoxVegan2);
        btnRandomDrink = view.findViewById(R.id.buttonRandomDrinkCoctelpedia);
        cbVegan.setOnClickListener(this);
        cbVegetarian.setOnClickListener(this);
        btnRandomDrink.setOnClickListener(this);


        whereArguments = new ArrayList<>();

        initializeData();
        initializeAdapter();

        initializeSpinnerOrderBy();
        initializeSpinnerType();

        return view;
    }

    @Override
    public void onClick(View view) {
        if(view.getId() == R.id.checkBoxVegan2|| view.getId() == R.id.checkBoxVegetarian2)
        {
            selection = "";
            addSelection();
            initializeData();
            initializeAdapter();
        }else if(view==btnRandomDrink)
        {
            btnRandomDrink.setEnabled(false);
            assert getFragmentManager() != null;
            FragmentTransaction transaction = getFragmentManager().beginTransaction();

            // Replace whatever is in the fragment_container view with this fragment,
            // and add the transaction to the back stack so the user can navigate back
            transaction.replace(R.id.containerCoctelpedia, new GifFragment());
            transaction.addToBackStack(null);
            // Commit the transaction
            transaction.commit();
            btnRandomDrink.setEnabled(true);
        }

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
        CoctelsAdapter adapter = new CoctelsAdapter(coctels);
        recyclerView.setAdapter(adapter);
    }

    private void initializeSpinnerOrderBy() {
        Spinner spinnerOrderBy = view.findViewById(R.id.spinnerOrderBy);
        // Create an ArrayAdapter using the string array and a default spinner layout
        ArrayAdapter<CharSequence> adapter = ArrayAdapter.createFromResource(Objects.requireNonNull(getContext()),
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
        spinnerType = view.findViewById(R.id.spinnerDrinkType);
        //Get the different types of drinks
        Cursor cursorTypes = coctelsOpenHelper.getTypes();

        //Add "All" field to the spinner, for that "all" field is added first to the ArrayList,
        // and later each item of the cursor
        ArrayList<String> spinnerArray = new ArrayList<>();

        spinnerArray.add(getString(R.string.title_all_drinks));
        for(cursorTypes.moveToFirst(); !cursorTypes.isAfterLast(); cursorTypes.moveToNext()) {
            spinnerArray.add(cursorTypes.getString(1));
        }

        ArrayAdapter<String> adapter = new ArrayAdapter<>(
                Objects.requireNonNull(getContext()), android.R.layout.simple_spinner_item, spinnerArray);
        adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);

        spinnerType.setAdapter(adapter);


        spinnerType.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener()
        {
            public void onItemSelected(AdapterView<?> parent, View view, int position, long id)
            {
                spinnerText = spinnerType.getSelectedItem().toString();

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


        if(!spinnerText.equals(getString(R.string.title_all_drinks)))
        {
            if(selection.equals(""))
            {
                add="type=?";
                whereArguments.add(spinnerText);
                selection=add;
            }
            else
            {
                add="AND type=?";
                whereArguments.add(spinnerText);
                selection+=add;
            }
        }
    }
}