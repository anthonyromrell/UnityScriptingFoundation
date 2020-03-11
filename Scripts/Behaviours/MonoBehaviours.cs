using UnityEngine;
using UnityEngine.Events;

public class MonoBehaviours : MonoBehaviour
{
    public UnityEvent startEvent;
    void Start()
    {
        startEvent.Invoke();
    }
}