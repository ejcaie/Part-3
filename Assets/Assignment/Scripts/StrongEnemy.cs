using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrongEnemy : Character
{
    Coroutine coroutine;
    protected override void Start()
    {
        base.Start();
        coroutine = StartCoroutine(Attack());
    }
    IEnumerator Attack()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            Instantiate(weaponPrefab, weaponSpawn.position, weaponSpawn.rotation);
        }
    }
}
