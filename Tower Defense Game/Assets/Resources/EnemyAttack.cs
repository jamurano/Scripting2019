﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public bool canAttack;
    private GameObject currentTower;
    public float attackTime;

    void OnTriggerEnter(Collider other)
    {
        canAttack = true;
        currentTower = transform.parent.gameObject;
        other.GetComponent<MoveSpeed>().enabled = false;
        StartCoroutine(AttackTimer());
        
    }

    public void Attack()
    {
        currentTower.GetComponent<ObjectData>().TakeDamage();
    }

    IEnumerator AttackTimer()
    {
        while(canAttack == true)
        {
            Attack();
            yield return new WaitForSeconds(attackTime);
        }
    }

}
