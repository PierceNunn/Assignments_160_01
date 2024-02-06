/*****************************************************************************
// File Name : Marathon.cs
// Author : Pierce Nunnelley
// Creation Date : January 25, 2024
//
// Brief Description : Establishes the Marathon class and its start function,
// which calculates the length of a marathon in kilometers and prints it out.
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marathon : MonoBehaviour
{
    /// <summary>
    /// The function that runs immediately upon loading into the scene.
    /// </summary>
    void Start()
    {
        const int YARDS_PER_MILE = 1760;
        const float KILOS_PER_MILE = 1.609f;
        /* A marathon is 26 miles, 385 yards */
        int miles, yards; //initializes miles and yards
        double kilometers;    //initializes kilometers
        miles = 26;
        yards = 385;

        //calculates kilometers by converting yards into miles, adding those to
        //the already existing miles, then converting the single number
        kilometers = (miles + (float)yards / YARDS_PER_MILE) * KILOS_PER_MILE;

        Debug.Log("A marathon is " + kilometers + " kilometers");

    }

}
