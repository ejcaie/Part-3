using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float speed = 5f;
    public float jump = 5f;
    Vector2 movement = Vector2.zero;
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        transform.Translate(movement.x * speed * Time.deltaTime, 0, 0);
        movement.y = Input.GetAxis("Vertical");
        transform.Translate(0, movement.y * jump * Time.deltaTime, 0);
    }
}
