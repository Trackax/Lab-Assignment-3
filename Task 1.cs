using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    public string Course_Name = "X";
    public float Challenge;
    public float Modules = 1f;
    public float Reading = 1f;
    public float Quizes = 1f;
    public float Assignments = 1f;
    public float Taught;
    // Start is called before the first frame update
    void Start()
    {
        float Challenge = Modules * 0.15f + Reading * 0.3f + Quizes * .15f + Assignments * .3f + Taught * 1;
        Debug.Log("Course - " + Course_Name);
        Debug.Log(Challenge);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
