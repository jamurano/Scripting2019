using System;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    public GameAction gameActionObj;
    private void OnStart()
    {
        gameActionObj.Raise();
    }
}