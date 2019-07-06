using System;

namespace TEDCore.MouseEvent
{
    public interface IMouseEventListener
    {
        IMouseEventListener AddMouseEnterAction(Action action);
        IMouseEventListener RemoveMouseEnterAction(Action action);
        IMouseEventListener ClearMouseEnterAction();
        IMouseEventListener AddMouseOverAction(Action action);
        IMouseEventListener RemoveMouseOverAction(Action action);
        IMouseEventListener ClearMouseOverAction();
        IMouseEventListener AddMouseExitAction(Action action);
        IMouseEventListener RemoveMouseExitAction(Action action);
        IMouseEventListener ClearMouseExitAction();
        IMouseEventListener AddMouseDownAction(int mouseButton, Action action);
        IMouseEventListener RemoveMouseDownAction(int mouseButton, Action action);
        IMouseEventListener ClearMouseDownAction(int mouseButton);
        IMouseEventListener AddMouseUpAction(int mouseButton, Action action);
        IMouseEventListener RemoveMouseUpAction(int mouseButton, Action action);
        IMouseEventListener ClearMouseUpAction(int mouseButton);
        IMouseEventListener AddMouseDragAction(int mouseButton, Action action);
        IMouseEventListener RemoveMouseDragAction(int mouseButton, Action action);
        IMouseEventListener ClearMouseDragAction(int mouseButton);
        IMouseEventListener AddMouseClickAction(int mouseButton, Action action);
        IMouseEventListener RemoveMouseClickAction(int mouseButton, Action action);
        IMouseEventListener ClearMouseClickAction(int mouseButton);
        IMouseEventListener AddMouseDoubleClickAction(int mouseButton, Action action);
        IMouseEventListener RemoveMouseDoubleClickAction(int mouseButton, Action action);
        IMouseEventListener ClearMouseDoubleClickAction(int mouseButton);
        void OnClick(int mouseButton);
        void OnDoubleClick(int mouseButton);
    }
}