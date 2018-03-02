using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprinklerBehavior : MonoBehaviour {

    public Transform startLoc;
    public Transform endLoc;
    public float speed;
    public bool activated;

    void Start() {
        gameObject.transform.position = startLoc.position;
        gameObject.GetComponentInChildren<ParticleSystem>().Stop();
        gameObject.GetComponent<CannonController>().enabled = false;
        activated = false;
    }

    void Update() {

        float step = speed * Time.deltaTime;

        if (activated == true) { 
            transform.position = Vector3.MoveTowards(transform.position, endLoc.position, step);
        }

    }

   

    public void startWater() {
        gameObject.GetComponentInChildren<ParticleSystem>().Play();
        gameObject.GetComponent<CannonController>().enabled = true;
    }
}
