using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaw : MonoBehaviour
{
    public Enemy enemy;
    public float spawnInterval;
    public int minSpawnAmount; 
    public int maxSpawnAmount;
    public float radius;

    float timeCount;
    GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        timeCount += Time.deltaTime;
        if (timeCount >= spawnInterval)
        {
            SpawnEnemies();
            timeCount = 0;
        }
    }

    void SpawnEnemies()
    {
        int enemiesToSpawn = Random.Range(minSpawnAmount, maxSpawnAmount);
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Vector2 enemyPos = (Vector2)player.transform.position + Random.insideUnitCircle * radius;
            Instantiate(enemy,enemyPos, Quaternion.identity);
        }
    }
}
