package com.example.unitylibrary;

import android.util.Log;

public class MyUnity {
    private static final String TAG = "MyUnity";
    public void testNoParam(){
        Log.i(TAG, "testNoParam: ");
    }

    public int testOneParam(String valStr){
        Log.i(TAG, "testOneParam: "+valStr);
        return 88;
    }

    /**
     * 静态方法工Unity调用
     * @param valStr
     * @return
     */
    public static int sTestOneParam(String valStr){
        Log.i(TAG, "sTestOneParam: "+valStr);
        return 99;
    }

}
