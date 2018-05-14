using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagemenet : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("AR_Module_Test");

    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}

