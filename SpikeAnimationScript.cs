using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeAnimationScript : MonoBehaviour {

    private float time;
    private float period = 4.0f;
    private bool binary = true;

	// Use this for initialization
	void Start () {
        time = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;

        if(time >= period && binary == true)
        {
            time = 0.0f;
            GetComponent<Animation>().Play("Rectraction");
            binary = false;
        }

        if (time >= period && binary == false)
        {
            time = 0.0f;
            GetComponent<Animation>().Play("Extension");
            binary = true;
        }
    }
}
