using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerGateOnCollision : MonoBehaviour {

    public GameObject Barrier;
    public GameObject Barrier1;
    public GameObject Barrier2;
    public GameObject Barrier3;
    public GameObject Particles;
    // Use this for initialization
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("collision");
            Destroy(Barrier);
            Destroy(Barrier1);
            Destroy(Barrier2);
            Destroy(Barrier3);
            Particles.SetActive(true);

        }
    }
}
