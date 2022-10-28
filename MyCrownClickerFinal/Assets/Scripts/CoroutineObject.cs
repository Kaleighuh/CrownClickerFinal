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

	public UnityEvent theshold1, theshold2, theshold3;
    
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
            }

            if (Ruby > 20)
            {
                Sparkles += sparklesValue;
                everySecondS.Invoke();
                Debug.Log("Sparkles " + Sparkles);
            }
            yield return waitTime;
        }
    }

	public void OnClickEnter()
	{
			
	}
}