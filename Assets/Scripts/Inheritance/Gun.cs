using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapon
{
    public Gun() : base()
    {
        WeaponName = "tommyGun";
    }

    public override void TakeDamage(int damage)
    {
        damage += 10;
    }
}
