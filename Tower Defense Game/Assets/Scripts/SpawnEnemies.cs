﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
    Vector3 position = new Vector3(45, Random.Range(16.0f, -16.0f), -10);
        Instantiate(prefab, position, Quaternion.identity);
    }
}
