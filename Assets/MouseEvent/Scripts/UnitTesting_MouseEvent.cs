using UnityEngine;
using TEDCore.MouseEvent;

public class UnitTesting_MouseEvent : MonoBehaviour
{
    private void Awake()
    {
        gameObject
            .AddMouseEnterAction(OnMouseEnterAction)
            .AddMouseExitAction(OnMouseExitAction)
            .AddMouseOverAction(OnMouseOverAction)
            .AddMouseDownAction(0, OnLeftMouseDownAction)
            .AddMouseDownAction(1, OnRightMouseDownAction)
            .AddMouseDownAction(2, OnMiddleMouseDownAction)
            .AddMouseUpAction(0, OnLeftMouseUpAction)
            .AddMouseUpAction(1, OnRightMouseUpAction)
            .AddMouseUpAction(2, OnMiddleMouseUpAction)
            .AddMouseDragAction(0, OnLeftMouseDragAction)
            .AddMouseDragAction(1, OnRightMouseDragAction)
            .AddMouseDragAction(2, OnMiddleMouseDragAction)
            .AddMouseClickAction(0, OnLeftMouseClickAction)
            .AddMouseClickAction(1, OnRightMouseClickAction)
            .AddMouseClickAction(2, OnMiddleMouseClickAction)
            .AddMouseDoubleClickAction(0, OnLeftMouseDoubleClickAction)
            .AddMouseDoubleClickAction(1, OnRightMouseDoubleClickAction)
            .AddMouseDoubleClickAction(2, OnMiddleMouseDoubleClickAction);
    }

    private void OnMouseEnterAction()
    {
        Debug.Log("Mouse Enter = " + name);
    }

    private void OnMouseExitAction()
    {
        Debug.Log("Mouse Exit = " + name);
    }

    private void OnMouseOverAction()
    {
        Debug.Log("Mouse Over = " + name);
    }

    private void OnLeftMouseDownAction()
    {
        Debug.Log("Left Mouse Down = " + name);
    }

    private void OnRightMouseDownAction()
    {
        Debug.Log("Right Mouse Down = " + name);
    }

    private void OnMiddleMouseDownAction()
    {
        Debug.Log("Middle Mouse Down = " + name);
    }

    private void OnLeftMouseUpAction()
    {
        Debug.Log("Left Mouse Up = " + name);
    }

    private void OnRightMouseUpAction()
    {
        Debug.Log("Right Mouse Up = " + name);
    }

    private void OnMiddleMouseUpAction()
    {
        Debug.Log("Middle Mouse Up = " + name);
    }

    private void OnLeftMouseDragAction()
    {
        Debug.Log("Left Mouse Drag = " + name);
    }

    private void OnRightMouseDragAction()
    {
        Debug.Log("Right Mouse Drag = " + name);
    }

    private void OnMiddleMouseDragAction()
    {
        Debug.Log("Middle Mouse Drag = " + name);
    }

    private void OnLeftMouseClickAction()
    {
        Debug.Log("Left Mouse Click = " + name);
    }

    private void OnRightMouseClickAction()
    {
        Debug.Log("Right Mouse Click = " + name);
    }

    private void OnMiddleMouseClickAction()
    {
        Debug.Log("Middle Mouse Click = " + name);
    }

    private void OnLeftMouseDoubleClickAction()
    {
        Debug.Log("Left Mouse Double Click = " + name);
    }

    private void OnRightMouseDoubleClickAction()
    {
        Debug.Log("Right Mouse Double Click = " + name);
    }

    private void OnMiddleMouseDoubleClickAction()
    {
        Debug.Log("Middle Mouse Double Click = " + name);
    }
}
