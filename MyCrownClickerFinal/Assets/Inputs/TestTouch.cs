using UnityEngine;

public class TestTouch : MonoBehaviour
{
    private InputsManager inputManager;
    private Camera cameraMain;

    private void Awake()
    {
        inputManager = InputsManager.Instance;
        cameraMain = Camera.main;
    }

    private void Enable()
    {
        inputManager.OnStartTouch += Move;
    }

    private void Disable()
    {
        inputManager.OnEndTouch -= Move;
    }

    public void Move(Vector2 screenPosition, float time)
    {
        Vector3 screenCoordinates = new Vector3(screenPosition.x, screenPosition.y, cameraMain.nearClipPlane);
        Vector3 worldCoordinates = cameraMain.ScreenToWorldPoint(screenCoordinates);
        worldCoordinates.z = 0;
        transform.position = worldCoordinates;
    }
}
