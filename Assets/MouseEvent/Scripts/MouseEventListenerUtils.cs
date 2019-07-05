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

        public static MouseEventListener AddMouseEnterAction(this MouseEventListener mouseEventListener, Action action)
        {
            return mouseEventListener.AddMouseEnterAction(action);
        }

        public static MouseEventListener RemoveMouseEnterAction(this GameObject gameObject, Action action)
        {
            return Get(gameObject).RemoveMouseEnterAction(action);
        }

        public static MouseEventListener RemoveMouseEnterAction(this MouseEventListener mouseEventListener, Action action)
        {
            return mouseEventListener.RemoveMouseEnterAction(action);
        }

        public static MouseEventListener ClearMouseEnterAction(this GameObject gameObject)
        {
            return Get(gameObject).ClearMouseEnterAction();
        }

        public static MouseEventListener ClearMouseEnterAction(this MouseEventListener mouseEventListener)
        {
            return mouseEventListener.ClearMouseEnterAction();
        }

        public static MouseEventListener AddMouseDragAction(this GameObject gameObject, int mouseButton, Action action)
        {
            return Get(gameObject).AddMouseDragAction(mouseButton, action);
        }

        public static MouseEventListener AddMouseDragAction(this MouseEventListener mouseEventListener, int mouseButton, Action action)
        {
            return mouseEventListener.AddMouseDragAction(mouseButton, action);
        }

        public static MouseEventListener RemoveMouseDragAction(this GameObject gameObject, int mouseButton, Action action)
        {
            return Get(gameObject).RemoveMouseDragAction(mouseButton, action);
        }

        public static MouseEventListener RemoveMouseDragAction(this MouseEventListener mouseEventListener, int mouseButton, Action action)
        {
            return mouseEventListener.RemoveMouseDragAction(mouseButton, action);
        }

        public static MouseEventListener ClearMouseDragAction(this GameObject gameObject, int mouseButton)
        {
            return Get(gameObject).ClearMouseDragAction(mouseButton);
        }

        public static MouseEventListener ClearMouseDragAction(this MouseEventListener mouseEventListener, int mouseButton)
        {
            return mouseEventListener.ClearMouseDragAction(mouseButton);
        }

        public static MouseEventListener AddMouseClickAction(this GameObject gameObject, int mouseButton, Action action)
        {
            return Get(gameObject).AddMouseClickAction(mouseButton, action);
        }

        public static MouseEventListener AddMouseClickAction(this MouseEventListener mouseEventListener, int mouseButton, Action action)
        {
            return mouseEventListener.AddMouseClickAction(mouseButton, action);
        }

        public static MouseEventListener RemoveMouseClickAction(this GameObject gameObject, int mouseButton, Action action)
        {
            return Get(gameObject).RemoveMouseClickAction(mouseButton, action);
        }

        public static MouseEventListener RemoveMouseClickAction(this MouseEventListener mouseEventListener, int mouseButton, Action action)
        {
            return mouseEventListener.RemoveMouseClickAction(mouseButton, action);
        }

        public static MouseEventListener ClearMouseClickAction(this GameObject gameObject, int mouseButton)
        {
            return Get(gameObject).ClearMouseClickAction(mouseButton);
        }

        public static MouseEventListener ClearMouseClickAction(this MouseEventListener mouseEventListener, int mouseButton)
        {
            return mouseEventListener.ClearMouseClickAction(mouseButton);
        }

        public static MouseEventListener AddMouseDoubleClickAction(this GameObject gameObject, int mouseButton, Action action)
        {
            return Get(gameObject).AddMouseDoubleClickAction(mouseButton, action);
        }

        public static MouseEventListener AddMouseDoubleClickAction(this MouseEventListener mouseEventListener, int mouseButton, Action action)
        {
            return mouseEventListener.AddMouseDoubleClickAction(mouseButton, action);
        }

        public static MouseEventListener RemoveMouseDoubleClickAction(this GameObject gameObject, int mouseButton, Action action)
        {
            return Get(gameObject).RemoveMouseDoubleClickAction(mouseButton, action);
        }

        public static MouseEventListener RemoveMouseDoubleClickAction(this MouseEventListener mouseEventListener, int mouseButton, Action action)
        {
            return mouseEventListener.RemoveMouseDoubleClickAction(mouseButton, action);
        }

        public static MouseEventListener ClearMouseDoubleClickAction(this GameObject gameObject, int mouseButton)
        {
            return Get(gameObject).ClearMouseDoubleClickAction(mouseButton);
        }

        public static MouseEventListener ClearMouseDoubleClickAction(this MouseEventListener mouseEventListener, int mouseButton)
        {
            return mouseEventListener.ClearMouseDoubleClickAction(mouseButton);
        }
    }
}