using UnityEngine;
using System;

namespace TEDCore.MouseEvent
{
    public static class MouseEventListenerUtils
    {
        private static IMouseEventListener Get(GameObject gameObject)
        {
            MouseEventListener mouseEventTrigger = gameObject.GetComponent<MouseEventListener>();
            if (mouseEventTrigger == null)
            {
                mouseEventTrigger = gameObject.AddComponent<MouseEventListener>();
            }

            return mouseEventTrigger;
        }

        public static IMouseEventListener AddMouseEnterAction(this GameObject gameObject, Action action)
        {
            return Get(gameObject).AddMouseEnterAction(action);
        }

        public static IMouseEventListener RemoveMouseEnterAction(this GameObject gameObject, Action action)
        {
            return Get(gameObject).RemoveMouseEnterAction(action);
        }

        public static IMouseEventListener ClearMouseEnterAction(this GameObject gameObject)
        {
            return Get(gameObject).ClearMouseEnterAction();
        }

        public static IMouseEventListener AddMouseOverAction(this GameObject gameObject, Action action)
        {
            return Get(gameObject).AddMouseOverAction(action);
        }

        public static IMouseEventListener RemoveMouseOverAction(this GameObject gameObject, Action action)
        {
            return Get(gameObject).RemoveMouseOverAction(action);
        }

        public static IMouseEventListener ClearMouseOverAction(this GameObject gameObject)
        {
            return Get(gameObject).ClearMouseOverAction();
        }

        public static IMouseEventListener AddMouseExitAction(this GameObject gameObject, Action action)
        {
            return Get(gameObject).AddMouseExitAction(action);
        }

        public static IMouseEventListener RemoveMouseExitAction(this GameObject gameObject, Action action)
        {
            return Get(gameObject).RemoveMouseExitAction(action);
        }

        public static IMouseEventListener ClearMouseExitAction(this GameObject gameObject)
        {
            return Get(gameObject).ClearMouseExitAction();
        }

        public static IMouseEventListener AddMouseDownAction(this GameObject gameObject, int mouseButton, Action action)
        {
            return Get(gameObject).AddMouseDownAction(mouseButton, action);
        }

        public static IMouseEventListener RemoveMouseDownAction(this GameObject gameObject, int mouseButton, Action action)
        {
            return Get(gameObject).RemoveMouseDownAction(mouseButton, action);
        }

        public static IMouseEventListener ClearMouseDownAction(this GameObject gameObject, int mouseButton)
        {
            return Get(gameObject).ClearMouseDownAction(mouseButton);
        }

        public static IMouseEventListener AddMouseUpAction(this GameObject gameObject, int mouseButton, Action action)
        {
            return Get(gameObject).AddMouseUpAction(mouseButton, action);
        }

        public static IMouseEventListener RemoveMouseUpAction(this GameObject gameObject, int mouseButton, Action action)
        {
            return Get(gameObject).RemoveMouseUpAction(mouseButton, action);
        }

        public static IMouseEventListener ClearMouseUpAction(this GameObject gameObject, int mouseButton)
        {
            return Get(gameObject).ClearMouseUpAction(mouseButton);
        }

        public static IMouseEventListener AddMouseDragAction(this GameObject gameObject, int mouseButton, Action action)
        {
            return Get(gameObject).AddMouseDragAction(mouseButton, action);
        }

        public static IMouseEventListener RemoveMouseDragAction(this GameObject gameObject, int mouseButton, Action action)
        {
            return Get(gameObject).RemoveMouseDragAction(mouseButton, action);
        }

        public static IMouseEventListener ClearMouseDragAction(this GameObject gameObject, int mouseButton)
        {
            return Get(gameObject).ClearMouseDragAction(mouseButton);
        }

        public static IMouseEventListener AddMouseClickAction(this GameObject gameObject, int mouseButton, Action action)
        {
            return Get(gameObject).AddMouseClickAction(mouseButton, action);
        }

        public static IMouseEventListener RemoveMouseClickAction(this GameObject gameObject, int mouseButton, Action action)
        {
            return Get(gameObject).RemoveMouseClickAction(mouseButton, action);
        }

        public static IMouseEventListener ClearMouseClickAction(this GameObject gameObject, int mouseButton)
        {
            return Get(gameObject).ClearMouseClickAction(mouseButton);
        }

        public static IMouseEventListener AddMouseDoubleClickAction(this GameObject gameObject, int mouseButton, Action action)
        {
            return Get(gameObject).AddMouseDoubleClickAction(mouseButton, action);
        }

        public static IMouseEventListener RemoveMouseDoubleClickAction(this GameObject gameObject, int mouseButton, Action action)
        {
            return Get(gameObject).RemoveMouseDoubleClickAction(mouseButton, action);
        }

        public static IMouseEventListener ClearMouseDoubleClickAction(this GameObject gameObject, int mouseButton)
        {
            return Get(gameObject).ClearMouseDoubleClickAction(mouseButton);
        }
    }
}