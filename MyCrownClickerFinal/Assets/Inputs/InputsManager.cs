using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputsManager : MonoBehaviour
{
    private Inputs touchControls;

    private void Awake()
    {
        touchControls = new Inputs();
    }

    private void OnEnable()
    {
        touchControls.Enable();
    }

    private void OnDisable()
    {
        touchControls.Disable();
    }

    private void Start()
    {
        touchControls.Touch.TouchPress.started += ctx => TouchStart(ctx);
        touchControls.Touch.TouchPress.canceled += ctx => TouchEnd(ctx);

    }

    private void TouchStart(InputAction.CallbackContext context)
    {
        Debug.Log("Touch started" + touchControls.Touch.TouchPosition.ReadValue<Vector2>());
    }

    private void TouchEnd(InputAction.CallbackContext context)
    {
        Debug.Log("Touch Ended");
    }
}
