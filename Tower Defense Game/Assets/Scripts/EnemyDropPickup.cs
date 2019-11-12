using System;
using UnityEngine;

public class EnemyDropPickup : MonoBehaviour
{
    public CoinData coinManager;
    public void OnMouseDown()
    {
        coinManager.AddCoin();
        Destroy(gameObject);
        Debug.Log(message: "Coin Destroyed");
        
    }

    public void Start()
    {
       coinManager = GameObject.Find("Coin Manager").GetComponent<CoinData>();
    }
}
