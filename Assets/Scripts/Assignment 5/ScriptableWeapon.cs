/*****************************************************************************
// File Name : ScriptableWeapon.cs
// Author : Pierce Nunnelley
// Creation Date : February 11, 2024
//
// Brief Description : This script is meant to hold data related to a weapon,
allowing easy creation of different weapons via the asset menu.
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//make sure it's in the asset menu
[CreateAssetMenu(fileName = "ScriptableWeapon", menuName = "Weapon")]
public class ScriptableWeapon : ScriptableObject
{
    [SerializeField] private string weaponName;
    [SerializeField] private string description;
    [SerializeField] private int damage;
    [SerializeField] private float reloadTime;

    //setters and getters here
    public string WeaponName { get => weaponName; set => weaponName = value; }
    public string Description 
    { get => description; set => description = value; }
    public int Damage { get => damage; set => damage = value; }
    public float ReloadTime { get => reloadTime; set => reloadTime = value; }

    /// <summary>
    /// Replaces toString method, returning info about the object.
    /// </summary>
    /// <returns>Info about the weapon.</returns>
    public override string ToString()
    {
        //put it all in one big string
        return weaponName + ": " + description + "\n Damage: " + damage
            + ", Reload Time: " + reloadTime + ".";
    }
}
