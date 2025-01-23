using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Anthony Rattigan and Donovan Peckham
public class Task3 : MonoBehaviour
{
    public int X = 0;
    private int Twenty;
    private int Ten;
    private int Five;
    private int One;
    // Start is called before the first frame update
    void Start()
    {
        Twenty = X / 20;
        X = X % 20;
        Ten = X / 10;
        X = X % 10;
        Five = X / 5;
        X = X % 5;
        One = X / 1;
        X = X % 1;
        Debug.Log("$20: " + Twenty);
        Debug.Log("$10: " + Ten);
        Debug.Log("$5: " + Five);
        Debug.Log("$1: " + One);
        Debug.Log("Remainder: $" + X);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
