using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DialogueController : MonoBehaviour, IPointerClickHandler
{
    public DialogueUI DialogueUI; 
    public DialogueSOs CurrentDialogueObject;
	public Animator animator;

    private void OnEnable()
    {
        DialogueUI.NextButton.onClick.AddListener(OnInteract);
		animator.SetBool("IsClosed", false);
    }

    private void OnDisable()
    {
        DialogueUI.ExitButton.onClick.RemoveListener(OnInteract);
		animator.SetBool("IsClosed", true);
    }

    public void OnInteract()
    {
        Debug.Log("Interact");
        DialogueUI.ShowText(CurrentDialogueObject.GetNextDialogue(), true);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
       OnInteract();
    }
}
