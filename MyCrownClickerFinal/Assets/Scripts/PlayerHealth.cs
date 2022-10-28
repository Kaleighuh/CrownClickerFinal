using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
   float playerHealth = 100;
   public UnityEvent PlayerDeath;
   public UnityEvent Reset;

   public void TakeDamage(float damage)
   {
      playerHealth -= damage;
      if (playerHealth < 0)
      {
         PlayerDeath.Invoke();
      } //Got from: https://gamedevbeginner.com/events-and-delegates-in-unity/#events
   }

   private void ResetGame(float damage)
      {
         if (playerHealth < 0)
         {
            Reset.Invoke();
         }
      }
   }
   
  
   
