using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{
    public GameObject knifePrefab;
    public Transform spawnPoint;
    Vector2 dashMovement;
    public float delay1 = 0.09f;
    public float delay2 = 0.22f;

    protected override void Attack()
    {
        speed = 10f;
        destination = transform.position;
        base.Attack();
        Invoke("SpawnKnife", delay1);
        Invoke("SpawnKnife", delay2);

        dashMovement = destination - (Vector2)transform.position;

        if (Input.GetMouseButtonDown(1) && isSelected && !clickingOnSelf)
        {
            destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if (dashMovement.x > 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (dashMovement.x < 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        if (dashMovement.magnitude < 0.1)
        {
            dashMovement = Vector2.zero;
        }
        rb.MovePosition(rb.position + dashMovement.normalized * speed * Time.deltaTime);
    }

    void SpawnKnife()
    {
        Instantiate(knifePrefab, spawnPoint.position, spawnPoint.rotation);
    }
    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }
}
