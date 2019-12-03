using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProjectile : MonoBehaviour
{
    public SO_Tower towerData;
    public bool canSpawn;
    public bool timedSpawnRunning = false;

    public void StartSpawn()
    {
        canSpawn = true;
        if (timedSpawnRunning == false)
        {
            StartCoroutine(TimedSpawn());
        }
    }

    public void StopSpawn()
    {
        canSpawn = false;
    }
    public void Spawn()
    {
        Instantiate(towerData.projectile, transform.position, Quaternion.identity);
    }

    IEnumerator TimedSpawn()
    {
        timedSpawnRunning = true;
        while(canSpawn == true)
        {
            Spawn();
            yield return new WaitForSeconds(towerData.fireSpeed);

        }

        timedSpawnRunning = false;
    }

}
