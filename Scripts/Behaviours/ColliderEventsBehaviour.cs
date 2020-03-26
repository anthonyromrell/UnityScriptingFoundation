using UnityEngine;
using UnityEngine.Events;

public class ColliderEventsBehaviour : MonoBehaviour
{
    public UnityEvent triggerEnterEvent, triggerExitEvent, 
        collisionEnterEvent, collisionExitEvent;

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
    
    private void OnTriggerExit(Collider other)
    {
        triggerExitEvent.Invoke();
    }

    private void OnCollisionEnter(Collision other)
    {
        collisionEnterEvent.Invoke();
    }
    
    private void OnCollisionExit(Collision other)
    {
        collisionExitEvent.Invoke();
    }
}