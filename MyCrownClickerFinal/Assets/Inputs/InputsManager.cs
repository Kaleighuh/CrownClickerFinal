using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;

[DefaultExecutionOrder(-1)]
public class InputsManager : Singleton<InputsManager>
{
    public delegate void StartTouchEvent(Vector2 position, float time);
    public event StartTouchEvent OnStartTouch;
    public delegate void EndTouchEvent(Vector2 position, float time);
    public event EndTouchEvent OnEndTouch;
    private Inputs touchControls;

    private void Awake()
    {
        touchControls = new Inputs();
    }

    private void OnEnable()
    {
        touchControls.Enable();
        TouchSimulation.Enable();
       // UnityEngine.InputSystem.EnhancedTouch.Touch.onFingerDown += FingerDown;

    }

    private void OnDisable()
    {
        touchControls.Disable();
        TouchSimulation.Disable();
        //UnityEngine.InputSystem.EnhancedTouch.Touch.onFingerDown -= FingerDown;

    }

    private void Start()
    {
        touchControls.Touch.TouchPress.started += ctx => TouchStart(ctx);
        touchControls.Touch.TouchPress.canceled += ctx => TouchEnd(ctx);
    }

    private void TouchStart(InputAction.CallbackContext context)
    {
        Debug.Log("Touch started" + touchControls.Touch.TouchPosition.ReadValue<Vector2>());
        if (OnStartTouch != null)
            OnStartTouch(touchControls.Touch.TouchPosition.ReadValue<Vector2>(), (float)context.startTime);
    }

    private void TouchEnd(InputAction.CallbackContext context)
    {
        Debug.Log("Touch Ended");
        if (OnEndTouch != null)
            OnEndTouch(touchControls.Touch.TouchPosition.ReadValue<Vector2>(), (float)context.time);
    }
    
    private void FingerDown()
    {
        
    }
}
