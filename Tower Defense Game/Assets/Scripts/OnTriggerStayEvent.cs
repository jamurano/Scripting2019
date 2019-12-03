using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerStayEvent : MonoBehaviour
{
    public UnityEvent onTriggerEvent;
    private void OnTriggerStay(Collider other)
    {
        onTriggerEvent.Invoke();
    }
}
