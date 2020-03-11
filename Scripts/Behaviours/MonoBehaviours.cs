using UnityEngine;
using UnityEngine.Events;

namespace UnityScriptingFoundation.Scripts.Behaviours
{
    public class MonoBehaviours : MonoBehaviour
    {
        public UnityEvent startEvent;

        void Start()
        {
            startEvent.Invoke();
        }
    }
}
    