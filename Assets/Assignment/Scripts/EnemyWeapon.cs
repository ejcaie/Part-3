using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : Projectiles
{
    protected override void FixedUpdate()
    {
        movement.x = -5;
        base.FixedUpdate();
    }
}
