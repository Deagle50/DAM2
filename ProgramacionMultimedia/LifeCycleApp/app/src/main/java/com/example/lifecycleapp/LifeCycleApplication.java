package com.example.lifecycleapp;

import android.app.Activity;
import android.app.Application;
import android.os.Bundle;
import android.util.Log;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

public class LifeCycleApplication extends Application implements Application.ActivityLifecycleCallbacks {
    @Override
    public void onCreate() {

        super.onCreate();
        registerActivityLifecycleCallbacks(this);
    }

    @Override
    public void onActivityCreated(@NonNull Activity activity, @Nullable Bundle savedInstanceState) {
        Log.i("", "Se creó la actividad");
    }

    @Override
    public void onActivityStarted(@NonNull Activity activity) {
        Log.i("",  "Se inició la actividad");
    }

    @Override
    public void onActivityResumed(@NonNull Activity activity) {
        Log.i("",  "Se reactivó la actividad");
    }

    @Override
    public void onActivityPaused(@NonNull Activity activity) {
        Log.i("", "Se pausó la actividad");
    }

    @Override
    public void onActivityStopped(@NonNull Activity activity) {
        Log.i("", "Se detuvo la actividad");
    }

    @Override
    public void onActivitySaveInstanceState(@NonNull Activity activity, @NonNull Bundle outState) {

    }

    @Override
    public void onActivityDestroyed(@NonNull Activity activity) {
        Log.i("", "Se destruyó la actividad");
    }
}
