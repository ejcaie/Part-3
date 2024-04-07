using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerControls : Character
{
    Coroutine coroutine;
    protected override void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.Space)) { Instantiate(weaponPrefab, weaponSpawn.position, weaponSpawn.rotation); }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        coroutine = StartCoroutine(whenHit());
    }
    IEnumerator whenHit()
    {
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(1);
        spriteRenderer.color = Color.white;
    }
}
