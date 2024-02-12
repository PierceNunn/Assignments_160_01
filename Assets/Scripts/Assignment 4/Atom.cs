/*****************************************************************************
// File Name : Atom.cs
// Author : Pierce Nunnelley
// Creation Date : February 11, 2024
//
// Brief Description : This script established the Atom class, which has 
values protons and electrons, as well as a print.
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atom : MonoBehaviour
{
    [SerializeField] private int protons;
    [SerializeField] private int electrons;

    protected int Protons { get => protons; set => protons = value; }
    protected int Electrons { get => electrons; set => electrons = value; }

    /// <summary>
    /// Constructor for the Atom class.
    /// </summary>
    /// <param name="p">value to set protons.</param>
    /// <param name="e">value to set electrons.</param>
    public Atom(int p, int e)
    {
        protons = p;
        electrons = e;
    }

    /// <summary>
    /// prints the values for Protons and Electrons of the atom.
    /// </summary>
    public virtual void PrintAtom()
    {
        print("Number of Protons: " + protons + "\n Number of Electrons: "
            + electrons);
    }

    /// <summary>
    /// runs PrintAtom on start.
    /// </summary>
    void Start()
    {
        PrintAtom();
    }

    /// <summary>
    /// Sets protons and electrons to 0.
    /// </summary>
    private void OnDestroy()
    {
        protons = 0;
        electrons = 0;
    }
}
