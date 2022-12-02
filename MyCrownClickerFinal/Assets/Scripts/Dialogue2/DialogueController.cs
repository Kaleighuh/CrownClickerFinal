using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DialogueController : MonoBehaviour, IPointerClickHandler
{
    public DialogueUI DialogueUI; 
    public DialogueSOs CurrentDialogueObject;

    private void OnEnable()
    {
        DialogueUI.NextButton.onClick.AddListener(OnInteract);
    }

    private void OnDisable()
    {
        DialogueUI.NextButton.onClick.RemoveListener(OnInteract);
    }

    public void OnInteract()
    {
        Debug.Log("Interact");
        DialogueUI.ShowText(CurrentDialogueObject.GetNextDialogue(), true);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
       // Oninteract();
    }
}
