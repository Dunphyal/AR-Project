using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroySphereOnContact : MonoBehaviour {

    private float time;
    public Text TimerText;
    public Text EndText;
    public Button Retry;
    public Button Menu;
    private string minutes;
    private string seconds;
    private bool finished = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("collision detected!");
            Destroy(other.gameObject);
            EndText.text = "Maze Completed in " + minutes + ":" + seconds;
            finished = true;
            Retry.gameObject.SetActive(true);
            Menu.gameObject.SetActive(true);

        }
    }

    private void Start()
    {
        time = 0.0f;
    }

    private void Update()
    {
        if (finished == false)
        {
            time += Time.deltaTime;
            minutes = ((int)time / 60).ToString();
            seconds = (time % 60).ToString("f2");

            TimerText.text = "Time: " + minutes + ":" + seconds;
        }
    }
}
