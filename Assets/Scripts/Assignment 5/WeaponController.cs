/*****************************************************************************
// File Name : WeaponController.cs
// Author : Pierce Nunnelley
// Creation Date : February 11, 2024
//
// Brief Description : This is a simple script meant to take in a 
ScriptableWeapon and use it in a scene, along with several associated
functions.
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField] ScriptableWeapon weapon;

    /// <summary>
    /// Function to run at the start.
    /// </summary>
    void Start()
    {
        PrintWeapon();
    }

    /// <summary>
    /// prints the ScriptableWeapon attached to the WeaponController.
    /// </summary>
    void PrintWeapon()
    {
        print(weapon); //easy since ToString is overridden in ScriptableWeapon
    }
}
