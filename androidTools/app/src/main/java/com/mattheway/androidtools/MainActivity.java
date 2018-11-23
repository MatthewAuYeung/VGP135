package com.mattheway.androidtools;

import android.Manifest;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;

import com.mattheway.tools.Utility;

public class MainActivity extends AppCompatActivity {

    private Utility utilityInstance = null;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        final Utility utilityInstance = Utility.Create(this,getApplicationContext());

        Button helloWorldButton = findViewById(R.id.helloWorldButton);

        helloWorldButton.setOnClickListener(new View.OnClickListener(){
            public void onClick(View v){
                Utility.HelloWorld();
            }
        });

        Button showToastButton = findViewById(R.id.showToastButton);
        showToastButton.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                utilityInstance.ShowToastMessage("This is my Toast");
            }
        });
        Button notificationTestButton = findViewById(R.id.notificationTestButton);
        notificationTestButton.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                utilityInstance.ShowNotification("Hello World", 0);
            }
        });
        Button delayNotificationTestButton = findViewById(R.id.delayNotificationTestButton);
        delayNotificationTestButton.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                utilityInstance.ShowNotification("Hello World", 1000);
            }
        });
    }

    public void OnPermissionRequestButtonClicked(View v){
        Log.d("Unity", "Permission button pressed");
        utilityInstance.RequestPermission(Manifest.permission.READ_CONTACTS);
    }

}