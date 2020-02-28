package com.deagle50.coctelpaedia.helpers;

import java.util.ArrayList;

public class StringHelper {
    private ArrayList<String> allStrings; //All the strings, you get strings from here
    public ArrayList<String> newStrings; //Growing string arrayList, you put here the strings in order
    private int previousInt=-1;
    private int rand=-1;
    public int i = 0;

    public StringHelper(ArrayList<String> strings) {
        this.allStrings = strings;
        newStrings = new ArrayList<>();
    }

    private String getRandomString(){
        if(rand!=-1)
            previousInt = rand;
        rand = ((int) (Math.random() * (allStrings.size())));
        if(previousInt!=-1)
        {
            while(rand==previousInt)
            {
                rand = ((int) (Math.random() * (allStrings.size())));
            }
        }
        return allStrings.get(rand);
    }

    public String getPreviousString(){
        if(i>0) {
            if(i==1)
            {
                i=0;
                return newStrings.get(i);
            }
            i--;
            return newStrings.get(i-1);
        }
        return null;
    }

    public String getNextString(){
        if(i<newStrings.size()-1)
        {
            i++;
            return newStrings.get(i);
        }
        return getRandomString();
    }

    public void saveString(String s){
        i++;
        newStrings.add(s);
    }
}
