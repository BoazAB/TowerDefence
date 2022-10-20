using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class enemyMoving : MonoBehaviour
{
    // array van de checkpoints
    [SerializeField]
    Transform[] waypoints;

    // aanpasbare movement speed
    public float moveSpeed = 2f;

    int waypointIndex = 0;

    void Start()
    {
        // zorgt er voor dat de gameobject naar de eerste waypoint gaat
        transform.position = waypoints[waypointIndex].transform.position;
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        // beweegt gameobject van 1 checkpoint richting de volgende
        transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, moveSpeed * Time.deltaTime);

        // zorgt er voor dat de volgende waypoint wordt gekozen
        if (transform.position == waypoints[waypointIndex].transform.position)
        {
            waypointIndex += 1;
        }

        // registreren als de enemy alle checkpoints geraakt heeft, zo ja dan worden ze gedelete
        if (waypointIndex == waypoints.Length)
        {
            Destroy(gameObject);
        }
    }
    //niet vergeten in Unity de checkpoints toe te voegen

}
