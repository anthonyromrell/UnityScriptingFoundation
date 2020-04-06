using System;
using UnityEngine;
using UnityEngine.Events;

public class MouseBehaviours : MonoBehaviour
    {
        public UnityEvent mouseDownEvent, mouseUpEvent, mouseEnterEvent;

        private void OnMouseDown()
        {
            mouseDownEvent.Invoke();
        }

        private void OnMouseUp()
        {
            mouseUpEvent.Invoke();
        }

        private void OnMouseEnter()
        {
            mouseEnterEvent.Invoke();
        }
}
