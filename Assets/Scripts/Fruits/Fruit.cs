/*****************************************************************************
// File Name : Fruit.cs
// Author : Pierce Nunnelley
// Creation Date : January 25, 2024
//
// Brief Description : Establishes the Fruit class, its constructors, and its 
functions.
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit
{
    public string name;
    public string color;
    public float weight;

    /// <summary>
    /// Constructor for fruit class that takes 3 parameters.
    /// </summary>
    /// <param name="name">the name of the fruit.</param>
    /// <param name="c">the color of the fruit.</param>
    /// <param name="w">the weight of the fruit in units.</param>
    public Fruit(string name, string c, float w)
    {
        this.name = name;
        color = c;
        weight = w;
    }
    /// <summary>
    /// Constructor for fruit class that takes no parameters.
    /// </summary>
    public Fruit()
    {
        name = "banana";
        color = "blue";
        weight = 3.7f;
    }
    /// <summary>
    /// Constructor for fruit class that takes one parameter.
    /// </summary>
    /// <param name="name">the name of the fruit.</param>
    public Fruit(string name)
    {
        this.name = name;
        color = "red";
        weight = 1.0f;
    }

    public Fruit(float weight)
    {
        name = "watermelon";
        color = "white";
        this.weight = weight;
    }

    ~Fruit()
    {
        name = "";
        weight = 0f;
        color = "clear";
    }
}
