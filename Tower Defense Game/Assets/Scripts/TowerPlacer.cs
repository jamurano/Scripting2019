using System;
using UnityEngine;
using UnityEngine.UI;

public class TowerPlacer : MonoBehaviour
{
    public Color hoverColor;
    private Color startColor;

    public Button towerSprite;

    public bool canSelect;

    private void Start()
    {
        
    }
    public void OnMouseDown()
    {
        Button icon = towerSprite.GetComponent<Button>();
        //OnMouseDown will select a tower from the Sprites available
    }

    public void OnMouseDrag()
    {
        //OnMouseDrag allows you to drag the selection to the grid
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
