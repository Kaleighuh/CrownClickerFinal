using UnityEngine;
using UnityEngine.Events;
public class TriggarEventBehaviour : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
    
}
