using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningDiff : MonoBehaviour
{
    public List<Enemy> enemies = new List<Enemy>();
    public int currWave;
    public int waveValue;
    public List<GameObject> enemiesToSpawn = new List<GameObject>();
    public List<GameObject> spawnedEnemies = new List<GameObject>();

    public Transform spawnLocation;
    public int waveDuration = 20;
    [SerializeField]
    private float waveTimer;
    private float spawnInterval;
    [SerializeField]
    private float spawnTimer;
    public float BetweenTime;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (BetweenTime <= 0) 
        {
            if (spawnTimer <= 0)
            {
                if (enemiesToSpawn.Count > 0)
                {
                    GameObject enemy = (GameObject)Instantiate(enemiesToSpawn[0], spawnLocation.position, Quaternion.identity);
                    enemiesToSpawn.RemoveAt(0);
                    spawnedEnemies.Add(enemy);
                    spawnTimer = spawnInterval;
                }
                else
                {
                    waveTimer = 0;
                }
            }
            else
            {
                spawnTimer -= Time.fixedDeltaTime;
                waveTimer -= Time.fixedDeltaTime;
            }

            if (waveTimer <= 0 && spawnedEnemies.Count <= 0)
            {
                Debug.Log("peepee");
                waveTimer = waveDuration + 5;
                currWave++;
                GenerateWave();
                BetweenTime = 5f;
            }
        }
        else if (BetweenTime > 0)
        { 
            TweenTime();
        }
    }

    public void TweenTime()
    {
        BetweenTime -= 0.5f * Time.deltaTime;
    }
    public void GenerateWave()
    {
        waveValue = currWave * 5;

            GenerateEnemies();
            spawnInterval = waveDuration / enemiesToSpawn.Count;
            waveTimer = waveDuration;
    }
    public void GenerateEnemies()
    {
        /*List of enemies
         Grabs random enemy
        See if can afford enemy
        if yes add to our list and deduct cost
        repeat until no more points*/

        List<GameObject> generatedEnemies = new List<GameObject>();
        while(waveValue > 0)
        {
            int randEnemyId = Random.Range(0, enemies.Count);
            int randEnemyCost = enemies[randEnemyId].cost;

            if(waveValue - randEnemyCost >= 0)
            {
                generatedEnemies.Add(enemies[randEnemyId].enemyPrefab);
                waveValue -= randEnemyCost;
            }
            else if (waveValue < 0)
            {
                break;
            }
        }
        enemiesToSpawn.Clear();
        enemiesToSpawn = generatedEnemies;
    }
}

[System.Serializable]
public class Enemy
{
    public GameObject enemyPrefab;
    public int cost;
}
