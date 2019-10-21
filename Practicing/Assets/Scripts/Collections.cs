﻿using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class Collections : ScriptableObject
{
    public List<Object> objectList;

    public List<FloatData> FloatDatas;

    public List<GameObject> GameObjects;

    public void FindObjectType(Object obj)
    {
        foreach (var currentOBJ in objectList)
        {
            if(currentOBJ == obj)
            {
                //Do Work;
            }
        }
    }

    public void AddToList(Object obj)
    {
        objectList.Add(obj);
    }

    public void RemoveFromList(Object obj)
    {
        foreach (var currentOBJ in objectList)
        {
            if (currentOBJ == obj)
            {
                objectList.Remove(obj);
            }
        }
}