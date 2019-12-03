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
        print(enemy);
        print(enemy.GetComponent<HealthData>());
        enemy.GetComponent<HealthData>().TakeDamage();
    }
}
