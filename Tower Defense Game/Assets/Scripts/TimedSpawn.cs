using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimedSpawn : MonoBehaviour
{
    public WaitForSeconds wfs;
    public float holdTime = .01f;

    public bool CanRun { get; set; } = true;

    public UnityEvent OnRunEvent;

    private void Awake()
    {
        wfs = new WaitForSeconds(holdTime);
    }

    public void Run()
    {
        StartCoroutine(OnStart());
    }

    private IEnumerator OnStart()
    {
        while (CanRun)
        {
            OnRunEvent.Invoke();
            yield return wfs;
        }
    }
}
