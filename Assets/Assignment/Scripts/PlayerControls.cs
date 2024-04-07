using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float speed = 100f;
    public Vector2 movement;
    Rigidbody2D rb;
    public GameObject knifePrefab;
    public Transform knifeSpawn;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.Space)) { Instantiate(knifePrefab, knifeSpawn.position, knifeSpawn.rotation); }
    }
    private void FixedUpdate()
    {
        rb.AddForce(speed * Time.deltaTime * movement);
    }
}
