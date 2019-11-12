using UnityEngine;

public class EnemyDrop : MonoBehaviour
{
    public GameObject coin;
    public void DropCoin()
    {
        print("Dropping Coin");
        Instantiate(coin, transform.position, Quaternion.identity);
    }
}
