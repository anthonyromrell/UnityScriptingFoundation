using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class ColliderEventsBehaviour : MonoBehaviour
{
    public UnityEvent triggerEnterEvent, triggerStayEvent, triggerExitEvent, 
        collisionEnterEvent, collisionStayEvent, collisionExitEvent;

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }

    private void OnTriggerStay(Collider other)
    {
        triggerStayEvent.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        triggerExitEvent.Invoke();
    }
    
    

    private void OnCollisionEnter(Collision other)
    {
        collisionEnterEvent.Invoke();
    }

    private void OnCollisionStay(Collision other)
    {
        collisionStayEvent.Invoke();
    }

    private void OnCollisionExit(Collision other)
    {
        collisionExitEvent.Invoke();
    }
}