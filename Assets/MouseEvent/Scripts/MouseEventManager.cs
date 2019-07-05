using UnityEngine;

namespace TEDCore.MouseEvent
{
    public class MouseEventManager : MonoSingleton<MouseEventManager>
    {
        private IMouseEventListener m_clickable;
        private int m_currentMouseButton;
        private float m_clickTimer;
        private IMouseEventListener m_lastClickable;
        private float m_doubleClickTimer;

        private void Update()
        {
            m_clickTimer -= Time.deltaTime;
            m_doubleClickTimer -= Time.deltaTime;
            if (m_doubleClickTimer <= 0)
            {
                m_lastClickable = null;
            }
        }

        public void SetMouseButton(int mouseButton)
        {
            m_currentMouseButton = mouseButton;
        }

        public void OnMouseDown(IMouseEventListener clickable)
        {
            m_clickable = clickable;
            m_clickTimer = 0.2f;
        }

        public void OnMouseUp(IMouseEventListener clickable)
        {
            if (m_clickable == null || m_clickable != clickable)
            {
                return;
            }

            if (m_clickTimer < 0)
            {
                m_clickable = null;
                return;
            }

            if (m_lastClickable != null && m_lastClickable == m_clickable)
            {
                m_clickable.OnDoubleClick(m_currentMouseButton);
                m_lastClickable = null;
                m_doubleClickTimer = 0f;
            }

            m_lastClickable = m_clickable;
            m_doubleClickTimer = 0.2f;

            m_clickable.OnClick(m_currentMouseButton);
            m_clickable = null;
        }
    }
}