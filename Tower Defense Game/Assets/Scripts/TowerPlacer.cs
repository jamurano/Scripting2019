using System;
using UnityEngine;
using UnityEngine.UI;

public class TowerPlacer : MonoBehaviour
{
    public Color hoverColor;
    private Color startColor;

    public GameObject selectedTower;
    public BuildManager bM;

    public bool canSelect;
  
    public void OnMouseDown()
    {
        selectedTower = bM.selectedTower;
        Vector3 pos = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1);
        Instantiate(selectedTower, pos, Quaternion.identity);
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
