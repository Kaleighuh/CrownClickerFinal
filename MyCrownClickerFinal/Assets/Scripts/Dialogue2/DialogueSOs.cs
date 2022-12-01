using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialogue Object", menuName = "Dialogue System")]
public class DialogueSOs : ScriptableObject
{
   public event System.Action DialogueComplete;
   public List<string> DialogueText;
   public bool isLoopable;
   public bool isOrdered;
   //public DialogueScriptableObject NextDialogue;

   private string dialogueID;
   private bool isCompleted;
   private Queue<string> orderedDialogue;
   private bool[] readHistory;

   public virtual string GetNextDialogue()
   {

      if (isOrdered)
      {
         if (orderedDialogue.Count > 0)
         {
            return orderedDialogue.Dequeue();
         }
         else
         {
            if (isLoopable)
            {
               BuildTextQueue();
               return orderedDialogue.Dequeue();
            }
            else
            {
               OnDialogueComplete();
            }
         }
      }



      int randomIndex = Random.Range(0, DialogueText.Count);
      return DialogueText[randomIndex];
   }

   public virtual void OnDialogueComplete()
      {
         DialogueComplete.Invoke();
      }

      private void OnEnable()
      {
         if (isOrdered)
         {
            BuildTextQueue();
         }
      }

      private void BuildTextQueue()
      {
         orderedDialogue = new Queue<string>();
         for (int i = 0; i < DialogueText.Count; i++)
         {
            orderedDialogue.Enqueue(DialogueText[i]);
         }
      }

}
