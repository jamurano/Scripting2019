using UnityEngine;

public class TriggerListener : MonoBehaviour
{
    public Object IRunObj;

    public UnityEvent Event { get; set; }

    public IRun NewIRunObj { get; set;  }

    void Start()
    {
        Event = new UnityEvent();
        public void OnTriggerEnter(Collider other)
        Event.AddListener(NewIRunObj.Run);
    {
            private void OnTriggerEvent(Collider other)
            {
                Event.Invoke();
                Event.RemoveListener(NewIRunObj.Run);
            }

        }
