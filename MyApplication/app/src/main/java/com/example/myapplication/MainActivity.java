package com.example.myapplication;


import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

public class MainActivity extends AppCompatActivity {
    private Button mYesButton;
    private Button mNoButton;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Button mYesButton = findViewById(R.id.button_yes);
        mYesButton.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View View)
            {
                Toast.makeText(MainActivity.this, R.string.correct_ans, Toast.LENGTH_LONG).show();
            }
        });
        Button mNoButton = findViewById(R.id.button_no);
        mNoButton.setOnClickListener(new View.OnClickListener() {
            public void onClick(View View) {
                Toast.makeText(MainActivity.this, R.string.incorrect_ans, Toast.LENGTH_LONG).show();
            }
        }
        );
    }
}