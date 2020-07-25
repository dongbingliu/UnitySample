using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("ss=================77=");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("ss================5666==");
    }

    public void TestAndroid()
    {
        AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");
        jo.Call("TestAndroid", "This is Unity11ss ");
        //AndroidJavaObject androidJavaObject = new AndroidJavaObject("com.example.unityandroid.MainActivity");

        //androidJavaObject.Call("testUnityAndroid",jo, "String msg come form Unity");
        Debug.Log("ss==================");
    }
}
