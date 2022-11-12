using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineObject : MonoBehaviour
{
    public UnityEvent everySecondG, everySecondR, everySecondS;
    public bool canRun;
    public int Gold;
    public int goldValue;
    public int Ruby;
    public int rubyValue;
    public int Sparkles;
    public int sparklesValue;
    //public float seconds = 1.0f;
    public WaitForSeconds waitTime = new WaitForSeconds(1);
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;

    private IEnumerator Start()
    {
        while (canRun)
        {
            Gold += goldValue;
            Debug.Log ("Gold equals " + Gold);
            everySecondG.Invoke();
            if (Gold > 10)
            {
                Ruby += rubyValue;
                everySecondR.Invoke();
                Debug.Log("Ruby equals " + Ruby);
                spriteRenderer.sprite = spriteArray[0];
            }

            if (Ruby > 20)
            {
                Sparkles += sparklesValue;
                everySecondS.Invoke();
                Debug.Log("Sparkles " + Sparkles);
                spriteRenderer.sprite = spriteArray[1];;
            }
            if (Gold >= 20 && Ruby >= 30 && Sparkles >= 10)
            {
                spriteRenderer.sprite = spriteArray[2];;
            }
            yield return waitTime;
        }
    }
    
}