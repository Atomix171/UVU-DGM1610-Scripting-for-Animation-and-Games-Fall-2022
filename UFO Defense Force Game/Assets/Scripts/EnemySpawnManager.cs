using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    
    private float spawnRangeX;
    private float spawnPosZ;

    private float startDelay = 2f;
    private float spawnInterval = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);

    }

    void SpawnRandomEnemy()
    {
        // Generate a postion to spawn at 
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        // Pick a random enemy/ufo from the array
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);

        //Spawn the enemy index from the array
        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);

    }
}
