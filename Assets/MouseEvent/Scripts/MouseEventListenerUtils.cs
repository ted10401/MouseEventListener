using UnityEngine;
using System;

namespace TEDCore.MouseEvent
{
    public static class MouseEventListenerUtils
    {
        private static MouseEventListener Get(GameObject gameObject)
        {
            MouseEventListener mouseEventTrigger = gameObject.GetComponent<MouseEventListener>();
            if (mouseEventTrigger == null)
            {
                mouseEventTrigger = gameObject.AddComponent<MouseEventListener>();
            }

            return mouseEventTrigger;
        }

        public static MouseEventListener AddMouseEnterAction(this GameObject gameObject, Action action)
        {
            return Get(gameObject).AddMouseEnterAction(action);
        }

        public static MouseEventListener RemoveMouseEnterAction(this GameObject gameObject, Action action)
        {
            return Get(gameObject).RemoveMouseEnterAction(action);
        }

        public static MouseEventListener ClearMouseEnterAction(this GameObject gameObject)
        {
            return Get(gameObject).ClearMouseEnterAction();
        }

        public static MouseEventListener AddMouseDownAction(this GameObject gameObject, int mouseButton, Action action)
        {
            return Get(gameObject).AddMouseDownAction(mouseButton, action);
        }

        public static MouseEventListener RemoveMouseDownAction(this GameObject gameObject, int mouseButton, Action action)
        {
            return Get(gameObject).RemoveMouseDownAction(mouseButton, action);
        }

        public static MouseEventListener ClearMouseDownAction(this GameObject gameObject, int mouseButton)
        {
            return Get(gameObject).ClearMouseDownAction(mouseButton);
        }

        public static MouseEventListener AddMouseUpAction(this GameObject gameObject, int mouseButton, Action action)
        {
            return Get(gameObject).AddMouseUpAction(mouseButton, action);
        }

        public static MouseEventListener RemoveMouseUpAction(this GameObject gameObject, int mouseButton, Action action)
        {
            return Get(gameObject).RemoveMouseUpAction(mouseButton, action);
        }

        public static MouseEventListener ClearMouseUpAction(this GameObject gameObject, int mouseButton)
        {
            return Get(gameObject).ClearMouseUpAction(mouseButton);
        }

        public static MouseEventListener AddMouseDragAction(this GameObject gameObject, int mouseButton, Action action)
        {
            return Get(gameObject).AddMouseDragAction(mouseButton, action);
        }

        public static MouseEventListener RemoveMouseDragAction(this GameObject gameObject, int mouseButton, Action action)
        {
            return Get(gameObject).RemoveMouseDragAction(mouseButton, action);
        }

        public static MouseEventListener ClearMouseDragAction(this GameObject gameObject, int mouseButton)
        {
            return Get(gameObject).ClearMouseDragAction(mouseButton);
        }

        public static MouseEventListener AddMouseClickAction(this GameObject gameObject, int mouseButton, Action action)
        {
            return Get(gameObject).AddMouseClickAction(mouseButton, action);
        }

        public static MouseEventListener RemoveMouseClickAction(this GameObject gameObject, int mouseButton, Action action)
        {
            return Get(gameObject).RemoveMouseClickAction(mouseButton, action);
        }

        public static MouseEventListener ClearMouseClickAction(this GameObject gameObject, int mouseButton)
        {
            return Get(gameObject).ClearMouseClickAction(mouseButton);
        }

        public static MouseEventListener AddMouseDoubleClickAction(this GameObject gameObject, int mouseButton, Action action)
        {
            return Get(gameObject).AddMouseDoubleClickAction(mouseButton, action);
        }

        public static MouseEventListener RemoveMouseDoubleClickAction(this GameObject gameObject, int mouseButton, Action action)
        {
            return Get(gameObject).RemoveMouseDoubleClickAction(mouseButton, action);
        }

        public static MouseEventListener ClearMouseDoubleClickAction(this GameObject gameObject, int mouseButton)
        {
            return Get(gameObject).ClearMouseDoubleClickAction(mouseButton);
        }
    }
}