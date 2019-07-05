using UnityEngine;
using TEDCore.MouseEvent;

public class UnitTesting_MouseEvent : MonoBehaviour
{
    private void Awake()
    {
        gameObject
            .AddMouseEnterAction(OnMouseEnterAction)
            .AddMouseExitAction(OnMouseExitAction)
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
