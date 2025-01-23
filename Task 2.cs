using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    public float X = 10f;
    public float Y = 5f;
    // Start is called before the first frame update
    void Start()
    {
        float Discount = Y * X * 0.4f;
        float Book = Y * X - Discount;
        float Shipping = Y * 0.75f + 2.25f;
        float Cost = Book + Shipping;
        float Profit = (X * Y) - Cost;
        Debug.Log("Cost: $" + Cost);
        Debug.Log("Profit: $" + Profit);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
