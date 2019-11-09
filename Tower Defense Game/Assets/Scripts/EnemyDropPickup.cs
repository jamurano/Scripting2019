using UnityEngine;

public class EnemyDropPickUp : MonoBehaviour
{
    public EnemyDrop getCoin;

    public void Start()
    {
        getCoin = GetComponent<EnemyDrop>();
    }

    public void OnMouseDown()
    {
        getCoin.DropCoin();
        Destroy(gameObject);
    }
}
