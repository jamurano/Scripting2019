using UnityEngine;

public class EnemyDrop : MonoBehaviour
{
    public GameObject coin;
    public Transform enemyPosition;
    public HealthData currentHealth;

    public void Start()
    {
        enemyPosition = GetComponent<Transform>();
    }

    public void DropCoin()
    {
        if (currentHealth != null)
        {
            Instantiate(coin, enemyPosition.position, Quaternion.identity);
        }
    }
}
