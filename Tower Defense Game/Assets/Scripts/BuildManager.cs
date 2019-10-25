using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public List<GameObject> towers;
    public GameObject selectedTower;

    public void SelectTower(int towerIndex)
    {
        selectedTower = towers[towerIndex];
        print("Selected Tower " + selectedTower);
    }
}
