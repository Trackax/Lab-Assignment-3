using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Anthony Rattigan and Donovan Peckham

//we interpreted the task as the percentages being difficulty multipliers for each section that are uncapped
//so a course with 100 modules and nothing else would still be 10 challenge score
//a course with 10 of each type and with a teacher that has taught before would calculate to exactly 10 challenge score
public class Task1 : MonoBehaviour
{
    //public inputs
    public string courseName;
    public int numModules;
    public int numReadings;
    public int numQuizzes;
    public int numAssignments;
    public bool hasTaught;

    // Start is called before the first frame update
    void Start()
    {
        
        //calculating the challenge score based on given values for the course multiplied by the difficulty percentage
        float score = 0;
        score += numModules * 0.15f;
        score += numReadings * 0.3f;
        score += numQuizzes * 0.15f;
        score += numAssignments * 0.3f;
        if (hasTaught) score++; //add 1 to challenge score if teacher has taught before, instead of 0.1 given that it is an all or nothing option
        if (score > 10) score = 10; //set score to 10 if values total more than 10, as 10 is the max challenge score
        if (score < 1) score = 1; //set score to 1 if values total less than 1, as 1 is the minimum challenge score
        
        //Display Course Name and Challenge Score
        Debug.Log("Course Name: " + courseName);
        Debug.Log("Challenge Score: " + score);
    }
}
