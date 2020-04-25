using UnityEngine;
using UnityEngine.Events;

public class TriggerBehaviours : MonoBehaviour
{
    public UnityEvent enableEvent, triggerEnterEvent, triggerExitEvent;

    private void OnEnable()
    {
        enableEvent.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        triggerExitEvent.Invoke();
    }
}