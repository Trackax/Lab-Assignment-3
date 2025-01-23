using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Anthony Rattigan and Donovan Peckham

//calculate what bills are paid based on the given payment amount
//use the highest bills possible
//ensure no remaining money unpaid
public class Task3 : MonoBehaviour
{  
    //public var for amount paid
    public int payment;
    
    // Start is called before the first frame update
    void Start()
    {
        //var to track remaining money
        int remaining = payment;

        //vars for amounts paid of each bill
        int twenty = 0;
        int ten = 0;
        int five = 0;
        int one = 0;

        //calculate amount of each bill starting with the highest bill going down 
        //go down the line starting with the highest bill
        twenty = remaining / 20;    //int division will only keep the whole number value of the total, therefore the total amount of that bill
        remaining %= 20;                 //modulus to take only the remainder, therfore the amount still left upaid
        ten = remaining / 10;
        remaining %= 10;
        five = remaining / 5;
        remaining %= 5;
        one = remaining / 1;
        remaining %= 1;

        Debug.Log("Amount Paid of Each Bill");
        Debug.Log("$20: " + twenty);
        Debug.Log("$10: " + ten);
        Debug.Log("$5: " + five);
        Debug.Log("$1: " + one);
        Debug.Log("Amount Remaining Unpaid: $" + remaining);
    }
}
