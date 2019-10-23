using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public List <GameObject> SpawnPoints;
    public List<GameObject> Enemies;

    public bool canSpawn;
    public float spawnTimeMin;
    public float spawnTimeMax;


    private void Start()
    {
        canSpawn = true;
        StartCoroutine(RandSpawn());
    }

    void SpawnEnemy()
    {
        //ERROR: ArrayOutOfIndex only when spawnPointNumber = 0;
        int spawnPointNumber = Random.Range(0, SpawnPoints.Count-1);
        print(spawnPointNumber);

        GameObject spawnPoint = SpawnPoints[spawnPointNumber];
        int enemyNumber = Random.Range(0, Enemies.Count);
        print(spawnPoint);
       // print(enemyNumber);
        GameObject enemy = Enemies[enemyNumber];
        Instantiate(enemy, spawnPoint.transform.position, Quaternion.identity);
    }

    IEnumerator RandSpawn()
    {
        while(canSpawn == true)
        {
            float spawnTime = Random.Range(spawnTimeMin, spawnTimeMax);
            SpawnEnemy();
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
