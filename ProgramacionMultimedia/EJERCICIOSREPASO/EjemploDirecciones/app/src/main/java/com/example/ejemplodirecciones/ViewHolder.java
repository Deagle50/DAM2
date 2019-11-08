package com.example.ejemplodirecciones;

import android.widget.TextView;

public class ViewHolder {

        public TextView txtColNom,txtColApe,txtColTlf;

        public ViewHolder(TextView txtNom, TextView txtApe, TextView txtTlf) {
            this.txtColNom = txtNom;
            this.txtColApe = txtApe;
            this.txtColTlf = txtTlf;
        }
        public void setNom(String txt)
        {
            txtColNom.setText(txt);
        }
        public void setApe(String txt)
        {
            txtColApe.setText(txt);
        }
        public void setTlf(String txt)
        {
            txtColTlf.setText(txt);
        }
    };


