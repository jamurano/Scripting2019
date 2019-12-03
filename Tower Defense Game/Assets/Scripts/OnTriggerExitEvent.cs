using UnityEngine;
using UnityEngine.Events;

public class OnTriggerExitEvent : MonoBehaviour
{
      public UnityEvent onTriggerEvent;
      private void OnTriggerExit(Collider other)
      {
          onTriggerEvent.Invoke();
      }
  }

