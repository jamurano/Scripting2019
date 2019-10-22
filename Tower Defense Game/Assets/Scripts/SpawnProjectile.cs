using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProjectile : MonoBehaviour
{
    public SO_Tower towerData;
    public bool canSpawn;

    public void Start()
    {
        canSpawn = true;
        StartCoroutine(TimedSpawn());
    }

    public void Spawn()
    {
        Instantiate(towerData.projectile, transform.position, Quaternion.identity);
    }

    IEnumerator TimedSpawn()
    {
        while(canSpawn == true)
        {
            Spawn();
            yield return new WaitForSeconds(towerData.fireSpeed);

        }
    }

}
