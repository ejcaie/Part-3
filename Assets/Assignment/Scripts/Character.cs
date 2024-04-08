using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed = 100f;
    public Vector2 movement;
    Rigidbody2D rb;
    protected SpriteRenderer spriteRenderer;
    public GameObject weaponPrefab;
    public Transform weaponSpawn;
    protected virtual void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    protected virtual void Update()
    {
        movement.x = Random.Range(-10, 11);
        movement.y = Random.Range(-10, 11);
    }
    private void FixedUpdate()
    {
        rb.AddForce(speed * Time.deltaTime * movement);
    }
}
