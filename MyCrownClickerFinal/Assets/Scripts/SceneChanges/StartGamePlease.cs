using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGamePlease : MonoBehaviour
{
    public int sceneToLoad;
    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad); // Scene to load
    }
    
}
