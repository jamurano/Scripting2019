using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class WaitForSec : MonoBehaviour
{
    public UnityEvent endOfTimerEvent;
    public float time;
    
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(time);
        endOfTimerEvent.Invoke();
    }

    public void StartTimer()
    {
        StartCoroutine(Timer());
    }
}
