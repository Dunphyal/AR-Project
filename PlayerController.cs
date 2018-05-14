using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    //public GameObject RespawnFlag;
    //public GameObject SpawnLoc;
    public GameObject FracturedBall;
    public Button Retry;
    

	// Use this for initialization


    void OnCollisionEnter(Collision other)
    {
        //if (other.gameObject.tag == "Respawn")
        //{
        //    Debug.Log("collision detected!");
        //    transform.position = SpawnLoc.transform.position;

        //}

        if (other.gameObject.tag == "Spike")
        {
            Destroy(gameObject);
            FracturedBall.transform.position = transform.position;
            FracturedBall.SetActive(true);
            Retry.gameObject.SetActive(true);
        }
    }


    // Update is called once per frame
    void Update () {


        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Debug.Log("BallSpawn");
            GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
