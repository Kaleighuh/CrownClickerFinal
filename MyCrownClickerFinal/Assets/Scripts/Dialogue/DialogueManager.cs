using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
	public Image actorImage;
	public Text actorName;
	public Text messageText;
	public RectTransform backgroundBox;

	private Message[] currentMessages;
	private Actor[] currentActors;
	private int activeMessage = 0;

	public void OpenDialogue(Message[] messages, Actor[] actors)
	{
		currentMessages = messages;
		currentActors = actors;
		activeMessage = 0;

		Debug.Log("Started Conversation" + messages.Length);
		DisplayDialogue();
	}
	public void DisplayDialogue()
	{
		Message messageToDisplay = currentMessages[activeMessage];
		messageText.text = messageToDisplay.message;
		
		Actor actorToDisplay = currentActors[messageToDisplay.actorID];
		actorName.text = actorToDisplay.name;
		actorImage.sprite = actorToDisplay.sprite;
	}

	public void NextMessage();
	{
		activeMessage++;
		if (activeMessage < currentMessages.Length)
		{
			DisplayDialogue();
		}
		else
		{
			Debug.Log("This Conversation is over!");
		}
	}
}

/*{
	public Text nameText;
	public Text dialogueText;

	private Queue<string> sentences;

    void Start()
    {
        sentences = new Queue<string>();
    }
	public void StartDialogue (Dialogue dialogue)
	{
		nameText.text = dialogue.name;

		sentences.Clear();
		
		foreach (string sentence in dialogue.sentences)
			{
				sentences.Enqueue(sentence);
			}
		DisplayNextSentence();
	}
	
	public void DisplayNextSentence()
	{
		if (sentences.Count == 0)
		{
			EndDialogue();
			return;
		}
		string sentence = sentences.Dequeue();
		dialogueText.text = sentence;
	}
	void EndDialogue()
	{
		Debug.Log("End of the Conversation.");
	}

}*/ //Brackies video that I am trying to figure out.
