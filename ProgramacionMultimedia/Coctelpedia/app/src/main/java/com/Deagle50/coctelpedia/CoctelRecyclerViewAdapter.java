package com.deagle50.coctelpedia;

import android.content.Context;
import android.graphics.Bitmap;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import java.util.List;

public class CoctelRecyclerViewAdapter extends RecyclerView.Adapter<CoctelRecyclerViewAdapter.ViewHolder> {

    private final List<Coctel> mValues;
    private final OnCoctelInteractionListener mListener;
    private Context ctx;

    public CoctelRecyclerViewAdapter(Context context, List<Coctel> items, OnCoctelInteractionListener listener) {
        ctx = context;
        mValues = items;
        mListener = listener;
    }

    @Override
    public ViewHolder onCreateViewHolder(ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(parent.getContext())
                .inflate(R.layout.item_coctel, parent, false);
        return new ViewHolder(view);
    }

    @Override
    public void onBindViewHolder(final ViewHolder holder, int position) {
        holder.mItem = mValues.get(position);

        holder.textViewCoctel.setText(holder.mItem.getNombre());
        holder.textViewGraduacion.setText(holder.mItem.getGraduacion().toString());
        holder.textViewCasa.setText(holder.mItem.getPrecioC().toString());
        holder.textViewBar.setText(holder.mItem.getPrecioB().toString());
        holder.textViewElaboracion.setText(holder.mItem.getElaboracion());
        holder.textViewDescripcion.setText(holder.mItem.getDescripcion());
        //holder.imageViewCoctel.setImageBitmap((Bitmap)holder.mItem.getUrlFoto());
        /*Glide.with(ctx)
                .load(holder.mItem.getUrlFoto())
                .into(holder.imageViewCoctel);
*/
        holder.mView.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (null != mListener) {
                    // Notify the active callbacks interface (the activity, if the
                    // fragment is attached to one) that an item has been selected.
                    mListener.onCoctelClick(holder.mItem);
                }
            }
        });
    }

    @Override
    public int getItemCount() {
        return mValues.size();
    }

    public class ViewHolder extends RecyclerView.ViewHolder {
        public final View mView;
        public final TextView textViewCoctel;
        public final TextView textViewGraduacion;
        public final TextView textViewCasa;
        public final TextView textViewBar;
        public final ImageView imageViewCoctel;
        public final TextView textViewDescripcion;
        public final TextView textViewElaboracion;
        public Coctel mItem;

        public ViewHolder(View view) {
            super(view);
            mView = view;
            textViewCoctel = view.findViewById(R.id.TextViewCoctel);
            textViewGraduacion = view.findViewById(R.id.textViewGraduacion);
            textViewCasa = view.findViewById(R.id.textViewCasa);
            textViewBar = view.findViewById(R.id.textViewBar);
            imageViewCoctel = view.findViewById(R.id.imageViewCoctel);
            textViewDescripcion = view.findViewById(R.id.textViewDescripcion);
            textViewElaboracion= view.findViewById(R.id.textViewElaboracion);
        }
    }
}