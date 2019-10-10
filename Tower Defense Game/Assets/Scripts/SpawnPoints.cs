using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    public GameAction gameActionObj;
    private void OnStart()
    {
        gameActionObj.Raise();
    }
}