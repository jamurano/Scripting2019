using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerSprite : MonoBehaviour
{
    public Button towerSpriteIcon;

    public bool canSelect;

    public void Start()
    {
        canSelect = true;
        StartCoroutine(SelectableTower());
    }

    public void OnMouseDown()
    {
        Button icon = towerSpriteIcon.GetComponent<Button>();
        //OnMouseDown will select a tower from the Sprites available
    }

    public void OnMouseDrag()
    {
        //OnMouseDrag allows you to drag the selection to the grid
    }

    IEnumerator SelectableTower()
    {
        while(canSelect == true)
        {
            OnMouseDown();
            //Need some way to force the player to either WaitForSeconds
            //to be able to select the tower again, or wait for there 
            //to be a certain amount of Mana before allowing selection again
            //I would like the sprite icons to be grayed out when selected
            //and while unable to select.

        }
    }
}
