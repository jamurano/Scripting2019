using UnityEngine;
using UnityEngine.UI;

public class ObjectData : MonoBehaviour
{
    public ObjectDefinition definition;
    public float maxHealth, currentHealth;

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
    }

    public void TakeDamage()
    {
        currentHealth = currentHealth - 10;
    }

}