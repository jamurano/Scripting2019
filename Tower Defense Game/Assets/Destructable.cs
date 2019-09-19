using UnityEngine;
using System.Collections;

public class Destructable : MonoBehaviour
{
    public float health = 100;
    public float damagePerCollision = 40;

    public DestructionSequence destructionSequence;

    public void TakeDamage(float damage)
    {
        if (health < 0) return;

        health -= damage;

        if (health < 0 && destructionSequence)
            StartCoroutine(destructionSequence.SequenceCoroutine(this));
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            TakeDamage(damagePerCollision);
        }
    }
}
