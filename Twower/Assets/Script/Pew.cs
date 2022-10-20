using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class Pew : MonoBehaviour
{

    private bool enemyOnScreen = true;

    [SerializeField]
    private GameObject bulletPrefab;

    [SerializeField]
    private float firerate = 3;


    void Start()
    {
        StartCoroutine(shooting(firerate, bulletPrefab));
    }
    private IEnumerator shooting(float interval, GameObject bullet)
    {
        yield return new WaitForSeconds(interval);
        GameObject newProjectile = Instantiate(bullet, transform.position, Quaternion.identity);
        GameObject newProjectile1 = Instantiate(bullet, transform.position, Quaternion.Euler(0,0,90));
        GameObject newProjectile2 = Instantiate(bullet, transform.position, Quaternion.Euler(0,0,-90));
        GameObject newProjectile3 = Instantiate(bullet, transform.position, Quaternion.Euler(0,0,180));
        StartCoroutine(shooting(interval, bullet));
    }
}