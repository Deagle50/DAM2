package com.deagle50.coctelpaedia.helpers;

import java.util.ArrayList;

public class StringHelper {
    private ArrayList<String> strings;
    private int previousInt=-1;
    private int nextInt;
    private int rand;

    public StringHelper(ArrayList<String> strings) {
        this.strings = strings;
    }

    public String getRandomString(){
        if(rand!=-1)
            previousInt = rand;
        rand = ((int) (Math.random() * (strings.size())));
        if(previousInt!=-1)
        {
            while(rand==previousInt)
            {
                rand = ((int) (Math.random() * (strings.size())));
            }
        }

        return strings.get(rand);
    }

    public String getPreviousString(){
        nextInt = rand;
        return strings.get(previousInt);
    }

    public String getNextString(){
        return strings.get(nextInt);
    }
}
