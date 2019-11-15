package com.example.vistadibujo;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.graphics.Point;
import android.graphics.drawable.ShapeDrawable;
import android.graphics.drawable.shapes.RectShape;
import android.view.View;

public class NuevaVista extends View {
    ShapeDrawable rectangulo = new ShapeDrawable((new RectShape()));
    ShapeDrawable triangulo = new ShapeDrawable(new TrianguloShape(new Point(100,100), new Point(200,200), new Point(0,200)));

    public NuevaVista(Context context) {
        super(context);
        rectangulo.getPaint().setColor(Color.RED);
    }

    @Override
    protected void onDraw(Canvas canvas) {
        super.onDraw(canvas);
        setBackgroundColor(Color.CYAN);
        rectangulo.setBounds(100,100,200,200);
        rectangulo.draw(canvas);
        Paint p = new Paint();
        p.setColor(Color.RED);
        triangulo.draw(canvas);
    }
}
