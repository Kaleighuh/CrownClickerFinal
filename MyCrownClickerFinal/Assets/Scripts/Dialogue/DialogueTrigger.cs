using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
/*{
   public Dialogue dialogue;

   public void TriggerDialogue()
   {
      FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
   }
}*/ //Brackies video that I am still trying to trouble shoot
{
   public Message[] messages;
   public Actor[] actors;

   public void StartDialogue()
   {
      FindObjectOfType<DialogueManager>().OpenDialogue(messages, actors);
   }
}
[System.Serializable]
public class Message
{
   public int actorID;
   public string message;
}

[System.Serializable]
public class Actor
{
   public string name;
   public Sprite sprite;
}
