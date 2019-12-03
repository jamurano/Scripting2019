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

    public bool hasTower = false;
    public HealthData towerHealth;

    public void OnMouseDown()
    {
        if (hasTower == false)
        { 
            if (bM.selectedTower != null)
            {
                GameObject tower;
                selectedTower = bM.selectedTower;
                coinManager.SubtractCoin(selectedTower.GetComponent<SpawnProjectile>().towerData.cost);
                Vector3 pos = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1);
                tower = Instantiate(selectedTower, pos, Quaternion.identity);
                towerHealth = tower.GetComponent<HealthData>();
                towerHealth.deathEvent.AddListener(OnTowerDestroyed);

                hasTower = true;
                bM.selectedTower = null; 
            }
            else
            {
                print("No tower selected");
            }
        }
    }

    public void OnTowerDestroyed()
    {
        hasTower = false;
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
