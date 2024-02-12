/*****************************************************************************
// File Name : Hydrogen.cs
// Author : Pierce Nunnelley
// Creation Date : February 11, 2024
//
// Brief Description : This script establishes the Hydrogen class, deriving
from the Atom class. it also overrides the PrintAtom function.
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hydrogen : Atom
{
    /// <summary>
    /// Constructor for the Hydrogen class.
    /// </summary>
    /// <param name="p">value to set protons.</param>
    /// <param name="e">value to set electrons.</param>
    public Hydrogen(int p, int e) : base(p, e)
    {
        Protons = p;
        Electrons = e;
    }

    /// <summary>
    /// Prints the number of protons in the Hydrogen.
    /// </summary>
    public override void PrintAtom()
    {
        print("Number of Protons: " + Protons);
    }
}
