package com.deagle50.coctelpedia.helpers;

import java.util.ArrayList;

public class StringHelper {
    private ArrayList<String> strings;
    private int previousInt=-1;
    private int nextInt;
    private int rand;

    public StringHelper(ArrayList<String> strings) {
        this.strings = strings;
    }

    private String getRandomString(){
        rand = ((int) (Math.random() * (strings.size() + 1)));
        if(previousInt!=-1)
        {
            while(rand==previousInt)
            {
                rand = ((int) (Math.random() * (strings.size() + 1)));
            }
        }
        previousInt = rand;
        return strings.get(rand);
    }

    private String getPreviousString(){
        nextInt = rand;
        return strings.get(previousInt);
    }

    private String getNextString(){
        return strings.get(nextInt);
    }
}
