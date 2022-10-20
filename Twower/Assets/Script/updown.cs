using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updown : MonoBehaviour
{
    public Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        velocity.x = Random.Range(-5, 10);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += velocity * Time.deltaTime;
        if (transform.position.x > 4.5)
        {
            velocity.x -= 15;
        }
        if (transform.position.x < -4.5)
        {
            velocity.x = 15;
        }

    }
}
