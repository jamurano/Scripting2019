using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public bool isTower;
    public bool isEnemy;
    private FloatData Health;

    void Start()
    {
        Health = gameObject.GetComponent<Health>();
    }

    void Update()
    {
        if (Health.health <= 0)
        {
            if (isTower)
            {
                Destroy(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
