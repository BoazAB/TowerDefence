using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoForward : MonoBehaviour
{
    public int moveSpeed = 3;
    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right *  Time.deltaTime * moveSpeed;
    }
}