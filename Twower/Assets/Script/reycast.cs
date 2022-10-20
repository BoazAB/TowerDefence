using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reycast : MonoBehaviour
{    // Update is called once per frame
    void Update()
    {
        if (Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.up), 200f))
        {
            Debug.Log("EEN MUUR WOW");
        }
        else
        {
            Debug.Log("er is niks te zien");
        }
    }
}
