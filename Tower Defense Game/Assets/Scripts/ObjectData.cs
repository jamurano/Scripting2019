using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectData : MonoBehaviour
{
    public ObjectDefinition definition;
    public float maxHealth, currentHealth;

    public float speed;

    void Start()
    {
        maxHealth = definition.maxHealth;
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
      if(currentHealth <= 0)
        {
            Destroy(gameObject);

            var speedVector = new Vector2(speed, 0) * Time.deltaTime;
            transform.Translate(speedVector);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        currentHealth = currentHealth - 10;
        Debug.Log("Took Damage!"); 
    }
}
