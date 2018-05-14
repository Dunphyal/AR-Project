using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {

    public void PlayGame2D()
    {
        SceneManager.LoadScene("AR_Module_test");

    }

    public void PlayGame3D()
    {
        SceneManager.LoadScene("ObjectScanMode");

    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
