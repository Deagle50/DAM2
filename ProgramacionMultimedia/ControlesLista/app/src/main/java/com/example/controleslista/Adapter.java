package com.example.controleslista;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import java.util.ArrayList;

public class Adapter extends RecyclerView.Adapter<RecyclerVersionArrayAdapter.ViewHolder> {
    private int resource;
    private Context parent;
    private ArrayList<androidversion> lista;

    public void RecyclerVersionArrayAdapter(Context context,int res, ArrayList<androidversion> list) {
        parent=context;
        resource=res;
        lista=list;
    }

    @NonNull
    @Override
    public ViewHolder onCreateViewHolder(@NonNull ViewGroup viewGroup, int i) {
        View v= LayoutInflater.from( viewGroup.getContext()).inflate(resource,viewGroup,false);
        TextView txtName,txtVersion,txtApi,txtYear;
        ImageView imgLogo;
        txtName=v.findViewById(R.id.txtName);
        txtVersion=v.findViewById(R.id.txtVersion);
        txtApi=v.findViewById(R.id.txtApi);
        txtYear=v.findViewById(R.id.txtYear);
        imgLogo=v.findViewById(R.id.imageView);
        return new RecyclerVersionArrayAdapter.ViewHolder(v,txtName,txtVersion,txtApi,txtYear,imgLogo);
    }

    @Override
    public void onBindViewHolder(@NonNull ViewHolder viewHolder, int i) {
        viewHolder.setApi(lista.get(i).getApi());
        viewHolder.setImgLogo(lista.get(i).getDrawableId());
        viewHolder.setName(lista.get(i).getName());
        viewHolder.setYear(lista.get(i).getYear());
        viewHolder.setTxtVersion(String.valueOf(lista.get(i).getVersion()));
    }

    @Override
    public int getItemCount() {
        return lista.size();
    }

    public class ViewHolder extends RecyclerView.ViewHolder {
        public TextView txtName,txtVersion,txtApi,txtYear;
        public ImageView imgLogo;

        public ViewHolder(@NonNull View itemView,TextView txtName, TextView txtVersion, TextView txtApi, TextView txtYear,ImageView imgLogo) {
            super(itemView);
            this.txtName = txtName;
            this.txtVersion = txtVersion;
            this.txtApi = txtApi;
            this.txtYear = txtYear;
            this.imgLogo=imgLogo;
        }


        public void setName(String txt)
        {
            txtName.setText(txt);
        }
        public void setTxtVersion(String txt)
        {
            txtVersion.setText(txt);
        }
        public void setApi(int num)
        {
            txtApi.setText(Integer.toString(num));
        }
        public void setYear(int num)
        {
            txtYear.setText(Integer.toString(num));
        }
        public void setImgLogo(int num){imgLogo.setImageDrawable(parent.getDrawable(num));}
    }

    {
}
