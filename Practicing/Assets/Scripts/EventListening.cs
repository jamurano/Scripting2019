
using UnityEngine;
using UnityEngine.Events;

public class EventListening : MonoBehaviour
{
    public Object IRunObj;
    public IRun newIRunObj;

    public IRun NewIRunObj { get; set; }

    public void Start()
    {
        newIRunObj = IRunObj as IRun;
        Event.AddListener(newIRunObj.Run);
    }


    private void OnMouseDown()
    {
        Event.Invoke();
        Event.RemoveListener(newIRunObj.Run);
    }
}