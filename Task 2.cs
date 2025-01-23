using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

//Anthony Rattigan and Donovan Peckham

//calculate wholesale price and profit for bookstore based on book price and units sold
public class Task2 : MonoBehaviour
{
    //public vars for cover price and books sold
    public float coverPrice;
    public float numBooks;

    // Start is called before the first frame update
    void Start()
    {
        float storePrice = coverPrice * 0.6f;   //calculate wholesale cost per book
        //Debug.Log(storePrice);
        float storeCost = storePrice * numBooks;        //total price store pays for books
        float shipping = (numBooks * 0.75f) + 2.25f;    //total shipping price; 2.25 covers the additional cost for the first copy of the book
        float wholesale = storeCost + shipping;         //total price bookstore pays
        float revenue = coverPrice * numBooks;          //store revenue from all books sold
        float profit = revenue - wholesale;             //profit store makes after factoring in purchase cost

        //print wholesale cost and profit
        Debug.Log("Wholesale Cost: $" + wholesale);
        Debug.Log("Store Profit: $" + profit); 
    }
}
