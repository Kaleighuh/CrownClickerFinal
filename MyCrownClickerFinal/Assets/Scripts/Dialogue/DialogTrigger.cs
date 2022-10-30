using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
   public Dialogue dialogue;

   public void TriggerDialogue()
   {
      findObjectOfType<DialogManager>().StartDialogue(dialogue);
   }
}
