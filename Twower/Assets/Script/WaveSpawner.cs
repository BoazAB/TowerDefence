using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;
    [SerializeField]
    private GameObject enemy1Prefab;

    //the amound of time between spawns of enemy
    [SerializeField]
    private float enemyInterval = 2f;
    [SerializeField]
    private float enemy1Interval = 7f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(enemyInterval, enemyPrefab));
        StartCoroutine(spawnEnemy(enemy1Interval, enemy1Prefab));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(0, 0, 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
