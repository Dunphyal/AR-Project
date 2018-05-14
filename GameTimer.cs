using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour {
    public Text TimerText;
    private float time;


    // Use this for initialization
    void Start()
    {
        time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        string minutes = ((int)time / 60).ToString();
        string seconds = (time % 60).ToString("f2");

        TimerText.text = "Time: " + minutes + ":" + seconds;

    }
}

