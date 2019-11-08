using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject enemy;
    private void OnTriggerEnter(Collider other)
    {
        enemy = other.gameObject;
        Attack();
        Destroy(gameObject);
    }
    public void Attack()
    {
        enemy.GetComponent<HealthData>().TakeDamage();
    }
}
