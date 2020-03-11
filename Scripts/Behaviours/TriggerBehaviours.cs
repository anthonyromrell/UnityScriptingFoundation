using UnityEngine;
using UnityEngine.Events;

namespace UnityScriptingFoundation.Scripts.Behaviours
{
    public class TriggerBehaviours : MonoBehaviour
    {
        public UnityEvent triggerEnterEvent;
    
        private void OnTriggerEnter(Collider other)
        {
            triggerEnterEvent.Invoke();
        }
    }
}