using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Joystick2 : MonoBehaviour
{
    public GameObject joystick;
    public GameObject joystickBG;
    public Vector2 joystickVec;
    private Vector2 joystickTouchPosition;
    private Vector2 joystickOrigionalPosition;
    private float joystickRadius;
    void Start()
    {
        joystickOrigionalPosition = joystickBG.transform.position;
        joystickRadius = joystickBG.GetComponent<RectTransform>().sizeDelta.y / 4;
    }

    public void OnPointerDown()
    {
        joystick.transform.position = Input.mousePosition;
        joystickBG.transform.position = Input.mousePosition;
        joystickTouchPosition = Input.mousePosition;
    }

    public void Drag(BaseEventData baseEventData)
    {
        PointerEventData pointerEventData = baseEventData as PointerEventData;
        Vector2 dragPos = pointerEventData.position;
        joystickVec = (dragPos - joystickTouchPosition).normalized;

        float joystickDisk = Vector2.Distance(dragPos, joystickTouchPosition);

        if (joystickDisk < joystickRadius)
        {
            joystick.transform.position = joystickTouchPosition + joystickVec * joystickDisk;
        }
        else
        {
            joystick.transform.position = joystickTouchPosition + joystickVec * joystickRadius;
        }
    }

    public void PointerUp()
    {
        joystickVec = Vector2.zero;
        joystickVec = joystickOrigionalPosition;
        joystickBG.transform.position = joystickOrigionalPosition;
    }

}
