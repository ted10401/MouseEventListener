using System;

namespace TEDCore.MouseEvent
{
    public interface IMouseEventListener
    {
        MouseEventListener AddMouseClickAction(int mouseButton, Action callback);
        MouseEventListener ClearMouseClickAction(int mouseButton);
        MouseEventListener AddMouseDoubleClickAction(int mouseButton, Action callback);
        MouseEventListener ClearMouseDoubleClickAction(int mouseButton);
        void OnClick(int mouseButton);
        void OnDoubleClick(int mouseButton);
    }
}