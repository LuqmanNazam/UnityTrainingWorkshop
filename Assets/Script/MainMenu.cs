using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void EnterScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ExitScene(string sceneName)
    {
        Application.Quit();
        Debug.Log("Application has quit");
    }
}
