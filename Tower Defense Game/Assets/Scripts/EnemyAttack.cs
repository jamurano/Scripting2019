using System.Collections;
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
        currentTower = other.gameObject;
        transform.parent.GetComponent<MoveSpeed>().enabled = false;
        StartCoroutine(AttackTimer());
        
    }

    public void Attack()
    {
        currentTower.GetComponent<HealthData>().TakeDamage();
        
        if(currentTower.GetComponent<HealthData>().currentHealth <= 0)
        {
            transform.parent.GetComponent<MoveSpeed>().enabled = true;
        }
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
