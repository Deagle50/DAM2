package com.example.vistadibujo;

import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.graphics.Point;
import android.graphics.drawable.ShapeDrawable;

public class TrianguloShape extends ShapeDrawable {
    Point p1, p2, p3;

    public TrianguloShape(Point p1, Point p2, Point p3) {
        this.p1 = p1;
        this.p2 = p2;
        this.p3 = p3;
    }

    @Override
    public void draw(Canvas canvas) {
        float[]lines={};
        Paint p=new Paint();
        p.setColor(Color.RED);

    }
}
