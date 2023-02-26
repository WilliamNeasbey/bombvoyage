using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuScript : MonoBehaviour
{
    public string LevelToLoad;
    //this is to try and remove other UI
    public GameObject[] gameObjectsToDisable;
    public GameObject[] gameObjectsToEnable;

    public void DisableObjectsOnClick()
    {
        foreach (GameObject gameObjectToDisable in gameObjectsToDisable)
        {
            gameObjectToDisable.SetActive(false);
        }
    }

    public void EnableObjectsOnClick()
    {
        foreach (GameObject gameObjectToEnable in gameObjectsToEnable)
        {
            gameObjectToEnable.SetActive(true);
        }
    }

    public void TitleScreen()
    {
        SceneManager.LoadScene("TitleScreen");
    }

    // MainHub
    public void Jotoro()
    {
        SceneManager.LoadScene("Lobby");
    }

    public void HomeRun()
    {
        SceneManager.LoadScene("LaunchTheBozo");
    }
}

