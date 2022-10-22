using UnityEngine;

public class MonoEventsBehavior : MonoBehaviour
{
    public UnityEvent startEvent, awakEvent, disableEvent;
    // Never put an event inside of an update
    private void Awake()
    {
        awakEvent.Invoke();
    }

    private void Start()
    {
        startEvent.Invoke();
    }

    private void OnDisable()
    {
        disableEvent.Invoke();
    }
}
