using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject EnemyPrefab;
    public int enemysInScene = 0;
    private int enemiesPerWave = 1;
    private float randomPosX;


    private Vector3 RandomSpawnPos()
    {
        randomPosX = Random.Range(-17.34f, 17.34f);
        return new Vector3(randomPosX, -0.66f, 20.03f);
    }
    private void SpawnEnemy()
    {
        Instantiate(EnemyPrefab, RandomSpawnPos(), Quaternion.identity);
        enemysInScene++;
    }
    private void SpawnEnemiesWave(int enemiestoSpawn)
    {
        for (int i = 0; i < enemiestoSpawn; i++)
        {
            SpawnEnemy();
        }
       
    }


    private void Start()
    {
        SpawnEnemiesWave(enemiesPerWave);
        
    }


    private void Update()
    {
        Debug.Log(enemysInScene);

        if (enemysInScene <= 0)
        {
            enemiesPerWave++;
            SpawnEnemiesWave(enemiesPerWave);
        }
    }
}
