using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoUnityJarScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TestOneMethod() {
        AndroidJavaObject androidJavaObject = new AndroidJavaObject("com.example.unitylibrary.MyUnity");
        androidJavaObject.Call("testNoParam");
  
    }

    public void TestTwoMethod() {
        AndroidJavaObject androidJavaObject = new AndroidJavaObject("com.example.unitylibrary.MyUnity");
        int result = androidJavaObject.Call<int>("testOneParam","This is one parm");
        Debug.Log("result = " + result);
    }

    public void TestThreeMethod()
    {
        AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.example.unitylibrary.MyUnity");
        int result = androidJavaClass.CallStatic<int>("sTestOneParam", "This is static one parm");
        Debug.Log("three method result = " + result);
    }


}
