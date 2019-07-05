﻿using UnityEngine;
using System;

namespace TEDCore.MouseEvent
{
    public class MouseEventListener : MonoBehaviour, IMouseEventListener
    {
        private readonly int[] MOUSE_BUTTON = { 0, 1, 2 };

        private Action m_onMouseEnter;
        private Action m_onMouseExit;
        private Action[] m_onMouseDrag = new Action[3];
        private Action[] m_onMouseClicks = new Action[3];
        private Action[] m_onMouseDoubleClicks = new Action[3];

        private void OnMouseEnter()
        {
            m_onMouseEnter?.Invoke();
        }

        private void OnMouseExit()
        {
            m_onMouseExit?.Invoke();
        }

        private void OnMouseDrag()
        {
            for (int i = 0; i < MOUSE_BUTTON.Length; i++)
            {
                if (Input.GetMouseButton(MOUSE_BUTTON[i]))
                {
                    m_onMouseDrag[i]?.Invoke();
                    break;
                }
            }
        }

        private void OnMouseOver()
        {
            for (int i = 0; i < MOUSE_BUTTON.Length; i++)
            {
                if (Input.GetMouseButtonDown(MOUSE_BUTTON[i]))
                {
                    MouseEventManager.Instance.OnMouseDown(this);
                    break;
                }
            }

            for (int i = 0; i < MOUSE_BUTTON.Length; i++)
            {
                if (Input.GetMouseButton(MOUSE_BUTTON[i]))
                {
                    MouseEventManager.Instance.SetMouseButton(MOUSE_BUTTON[i]);
                    break;
                }
            }

            for (int i = 0; i < MOUSE_BUTTON.Length; i++)
            {
                if (Input.GetMouseButtonUp(MOUSE_BUTTON[i]))
                {
                    MouseEventManager.Instance.OnMouseUp(this);
                    break;
                }
            }
        }

        public MouseEventListener AddMouseEnterAction(Action action)
        {
            m_onMouseEnter += action;
            return this;
        }

        public MouseEventListener RemoveMouseEnterAction(Action action)
        {
            m_onMouseEnter -= action;
            return this;
        }

        public MouseEventListener ClearMouseEnterAction()
        {
            m_onMouseEnter = null;
            return this;
        }

        public MouseEventListener AddMouseExitAction(Action action)
        {
            m_onMouseExit += action;
            return this;
        }

        public MouseEventListener RemoveMouseExitAction(Action action)
        {
            m_onMouseExit -= action;
            return this;
        }

        public MouseEventListener ClearMouseExitAction()
        {
            m_onMouseExit = null;
            return this;
        }

        public MouseEventListener AddMouseDragAction(int mouseButton, Action action)
        {
            m_onMouseDrag[mouseButton] += action;
            return this;
        }

        public MouseEventListener RemoveMouseDragAction(int mouseButton, Action action)
        {
            m_onMouseDrag[mouseButton] -= action;
            return this;
        }

        public MouseEventListener ClearMouseDragAction(int mouseButton)
        {
            m_onMouseDrag[mouseButton] = null;
            return this;
        }

        public MouseEventListener AddMouseClickAction(int mouseButton, Action action)
        {
            m_onMouseClicks[mouseButton] += action;
            return this;
        }

        public MouseEventListener RemoveMouseClickAction(int mouseButton, Action action)
        {
            m_onMouseClicks[mouseButton] -= action;
            return this;
        }

        public MouseEventListener ClearMouseClickAction(int mouseButton)
        {
            m_onMouseClicks[mouseButton] = null;
            return this;
        }

        public MouseEventListener AddMouseDoubleClickAction(int mouseButton, Action action)
        {
            m_onMouseDoubleClicks[mouseButton] += action;
            return this;
        }

        public MouseEventListener RemoveMouseDoubleClickAction(int mouseButton, Action action)
        {
            m_onMouseDoubleClicks[mouseButton] -= action;
            return this;
        }

        public MouseEventListener ClearMouseDoubleClickAction(int mouseButton)
        {
            m_onMouseDoubleClicks[mouseButton] = null;
            return this;
        }

        public void OnClick(int mouseButton)
        {
            m_onMouseClicks[mouseButton]?.Invoke();
        }

        public void OnDoubleClick(int mouseButton)
        {
            m_onMouseDoubleClicks[mouseButton]?.Invoke();
        }
    }
}