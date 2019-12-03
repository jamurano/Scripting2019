using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerEnterEvent : MonoBehaviour
{
    public UnityEvent OnTriggerEvent;
    public void OnTriggerEnter(Collider other)
    {
        OnTriggerEvent.Invoke();
    }
}
