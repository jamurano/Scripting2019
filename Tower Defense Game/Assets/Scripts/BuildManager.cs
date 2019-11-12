using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public List<GameObject> towers;
    public GameObject selectedTower;

    public CoinData coinManager;

    public void SelectTower(int towerIndex)
    {
        if (towers[towerIndex].GetComponent<SpawnProjectile>().towerData.cost <= coinManager.currentCoins)
        {
            selectedTower = towers[towerIndex];
        }
        else
        {
            selectedTower = null;
            print("Not Enough Coins");
        }
    }
}
