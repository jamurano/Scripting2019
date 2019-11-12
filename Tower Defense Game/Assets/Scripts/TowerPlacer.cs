using System;
using UnityEngine;
using UnityEngine.UI;

public class TowerPlacer : MonoBehaviour
{
    public Color hoverColor;
    private Color startColor;

    public GameObject selectedTower;
    public BuildManager bM;

    public CoinData coinManager;
  
    public void OnMouseDown()
    {
        if (bM.selectedTower != null)
        {
            selectedTower = bM.selectedTower;
            coinManager.SubtractCoin(selectedTower.GetComponent<SpawnProjectile>().towerData.cost);
            Vector3 pos = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1);
            Instantiate(selectedTower, pos, Quaternion.identity);
        }
        else
        {
            print("No tower selected");
        }
    }
    
    public void OnMouseEnter()
    {
        //hoverColor
    }

    private void OnMouseExit()
    {
        //returns to normal color
    }
}
