using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryScript : MonoBehaviour {

    public GameObject ball;
    public GameObject SpawnLoc;

    public void ReloadScene()
    {
        Debug.Log("Reloading");
        SceneManager.LoadScene("AR_Module_test");
    }

    public void LoadMenu()
    {

        SceneManager.LoadScene("Menu");
    }

    public void RespawnBall()
    {
        ball.transform.position = new Vector3(SpawnLoc.transform.position.x, SpawnLoc.transform.position.y, SpawnLoc.transform.position.z);
    }
}
