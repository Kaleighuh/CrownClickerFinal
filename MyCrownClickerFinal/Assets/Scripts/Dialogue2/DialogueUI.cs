using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DialogueUI : MonoBehaviour
{
    public event System.Action TypingTextEnded;
    public Text DialogueBoxText;
    public Button NextButton;
	public Button ExitButton;
    public float TypeTextDelay = 0.05f;

    public void ShowText(string text, bool shouldType)
    {
        this.gameObject.SetActive(true);
        if (shouldType)
        {
            StartCoroutine(TypeText(text));
        }
        else
        {
            DialogueBoxText.text = text;
        }
    }

    private IEnumerator TypeText(string text)
    {
        string fullText = text;
        string currentText;
        for (int i = 0; i < fullText.Length + 1; i++)
        {
			//Time.timeScale = 0;
            currentText = fullText.Substring(0, i);
            DialogueBoxText.text = currentText;
            yield return new WaitForSeconds(TypeTextDelay);
        }

        TypingTextEnded.Invoke();
        yield return null;
		//Time.timeScale = 1;
    }
}
