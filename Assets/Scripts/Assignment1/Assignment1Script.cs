/*****************************************************************************
// File Name : Assignment1Script.cs
// Author : Pierce Nunnelley
// Creation Date : January 30, 2024
//
// Brief Description : This script has two primary functionalities; first, it
runs three different print functions on three arrays of different types, each
displayed in a different way. Additionally, the script acts as a box spawner 
and destroyer, storing all created boxes in an Arraylist to allow easy deletion
of all instances.
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment1Script : MonoBehaviour
{
    //establishing arrays to do functions on here
    private int[] intArray = { 5, 4, 7, 12, 96868 };
    private float[] floatArray = { 4.4f, 1.24f, 99.99f, 1.1f, 6.9f };
    private string[] stringArray = {"hello", "array", "awesome", "mi?", "qe"};
    //spawnedCrates holds references to all crates spawned by script
    private List<GameObject> spawnedCrates = new List<GameObject>();
    public GameObject crate; //prefab to spawn
    /// <summary>
    /// Runs at start, calling all of the custom Print functions
    /// </summary>
    void Start()
    {
        PrintIntArray(intArray);
        PrintFloatArray(floatArray);
        PrintStringArray(stringArray);
    }
    /// <summary>
    /// Instantiates a new crate and adds it to the spawnedCrates arrayList.
    /// </summary>
    public void OnSpawnCrate()
    {
        spawnedCrates.Add(Instantiate(crate, transform.position,
            Quaternion.identity));
    }
    /// <summary>
    /// Iterates through spawnedCrates arraylist, destroying every stored 
    /// instance.
    /// </summary>
    public void OnDestroyCrates()
    {
        foreach(GameObject g in spawnedCrates)
            Destroy(g);
    }

    /// <summary>
    /// Prints the sum of all ints in an int array.
    /// </summary>
    /// <param name="a">the int array to act on.</param>
    void PrintIntArray(int[] a)
    {
        int result = 0;
        for (int i = 0; i < a.Length; i++)
            result += a[i];
        print(result);
    }

    /// <summary>
    /// Prints each float in a float array in reverse order.
    /// </summary>
    /// <param name="a">the float array to act on.</param>
    void PrintFloatArray(float[] a)
    {
        string result = "";
        for (int i = a.Length - 1; i > 0; i--)//starts at last ind., works back
            result = result + a[i] + " "; //add to print string
        print(result);
    }

    /// <summary>
    /// Prints each string in a string array in order, written backwards.
    /// </summary>
    /// <param name="a">the string array to act on.</param>
    void PrintStringArray(string[] a)
    {
        string result = "";
        for (int i = 0; i < a.Length; i++) 
            result = result + ReverseString(a[i]) + " "; //add to print string
        print(result);
    }

    /// <summary>
    /// Takes a string and converts it to be written backwards.
    /// </summary>
    /// <param name="s">The string to reverse.</param>
    /// <returns>The input string, written backwards.</returns>
    string ReverseString(string s)
    {
        char[] a = s.ToCharArray(); //convert string to an array of chars
        System.Array.Reverse(a); //reverse order of chars in array
        return new string(a); //put reversed chars back together as string
    }
}
