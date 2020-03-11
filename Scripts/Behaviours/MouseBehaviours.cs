using UnityEngine;
using UnityEngine.Events;

namespace UnityScriptingFoundation.Scripts.Behaviours
{
    public class MouseBehaviours : MonoBehaviour
    {
        public UnityEvent mouseDownEvent, mouseEnterEvent;

        private void OnMouseDown()
        {
            mouseDownEvent.Invoke();
        }

        private void OnMouseEnter()
        {
            mouseEnterEvent.Invoke();
        }
    }
}