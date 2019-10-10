using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        Vector3 position = new Vector3(45, Random.Range(16.0f, -16.0f), -10);
        Instantiate(prefab, position, Quaternion.identity);
    }
}
