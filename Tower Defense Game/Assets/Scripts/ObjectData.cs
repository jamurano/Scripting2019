using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectData : MonoBehaviour
{
    public ObjectDefinition definition;
    public float maxHealth, currentHealth;

    public float moveSpeed;

    void Start()
    {
        maxHealth = definition.maxHealth;
        currentHealth = maxHealth;
    }

    void Update()
    {

      if(currentHealth <= 0)
        {
            Destroy(gameObject);
        }

        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        currentHealth = currentHealth - 10;
        Debug.Log("Took Damage!"); 
    }

}