/*****************************************************************************
// File Name : FruitManager.cs
// Author : Pierce Nunnelley
// Creation Date : January 25, 2024
//
// Brief Description : Establishes the FruitManager class and its 
functions.
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitManager : MonoBehaviour
{
    public List<Fruit> fruitSalad;
    // Start is called before the first frame update
    void Start()
    {
        fruitSalad = new List<Fruit>();

        Fruit apple = new Fruit("apple", "green", 1.2f);
        fruitSalad.Add(apple);

        CreateFruitSalad();
        DisplayFruitSalad();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DisplayFruitSalad()
    {
       for(int i = 0; i < fruitSalad.Count; i++)
        {
            print(fruitSalad[i].color + " " + fruitSalad[i].name + " weighs " + fruitSalad[i].weight + " units");
        }
    }

    void CreateFruitSalad()
    {
        fruitSalad.Add(new Fruit());
        fruitSalad.Add(new Fruit("strawberry"));
        fruitSalad.Add(new Fruit(7.8f));
    }
}
