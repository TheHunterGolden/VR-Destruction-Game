using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprinklerBehavior : MonoBehaviour {

    public Transform startLoc;
    public Transform endLoc;
    public float speed;
    public bool activated;
    public GameObject spring;
    public GameObject vrtk;
    public GameObject mineLevel;
    public GameObject floor;
    private bool enableTeleport;
    private float height;
    private bool workAsButton;

    void Start() {
        gameObject.transform.position = startLoc.position;
        gameObject.GetComponentInChildren<ParticleSystem>().Stop();
        gameObject.GetComponent<CannonController>().enabled = false;
        activated = false;
        height = 6.8f;
        workAsButton = false;
        enableTeleport = false;
        Physics.IgnoreCollision(gameObject.GetComponent<CapsuleCollider>(), floor.GetComponent<BoxCollider>());
    }

    void Update() {

        float step = speed * Time.deltaTime;

        if (activated == true) { 
            transform.position = Vector3.MoveTowards(transform.position, endLoc.position, step);
        }

        if (transform.localPosition.y >= height && gameObject.tag == "SprinklerButton")
        {
            workAsButton = true;
            spring.SetActive(true);
            enableTeleport = true;
        }

        if (workAsButton && transform.localPosition.y > height)
        {
            Vector3 position = transform.localPosition;
            position.y = 6.8f;
            transform.localPosition = position;
        }

        if (workAsButton && height - transform.localPosition.y >= 0.4)
        {
            enableTeleport = false;
            vrtk.transform.localPosition = mineLevel.transform.localPosition;
        }
    }

   

    public void startWater() {
        gameObject.GetComponentInChildren<ParticleSystem>().Play();
        gameObject.GetComponent<CannonController>().enabled = true;
    }


}
