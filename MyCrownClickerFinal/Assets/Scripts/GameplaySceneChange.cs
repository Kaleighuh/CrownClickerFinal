using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplaySceneChange : MonoBehaviour
{
    public bool canRun;
    public int Gold;
    public int Ruby;
    public int Sparkles;
    //public float seconds = 1.0f;
    
    public int sceneToLoad; // loading scene

    public void PrincessScene()
    {
        if (Gold >= 1000 && Ruby >= 300 && Sparkles >= 60);
        {
            SceneManager.LoadScene(sceneToLoad); // load the Princess Scene
        }
    }
}
