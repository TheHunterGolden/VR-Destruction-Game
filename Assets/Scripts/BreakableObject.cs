﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BreakableObject : MonoBehaviour {



    public GameObject areaOfEffect;
    public float timer;
    public bool startTimer;
    public bool destroyOverTime;
    public bool useTimer;
    void Start() {
        timer = 3;
        startTimer = false;
    }

    void Update()
    {

        if ((startTimer == true) && (useTimer)) { 
            timer -= Time.deltaTime;
            gameObject.transform.localScale -= new Vector3(0.3f, 0.3f, 0.3f);
        }

        if ((destroyOverTime == true) && (timer <= 0)) {
            Destroy(gameObject);
        }

    }

    void OnCollisionStay(Collision col) {

        ContactPoint contact = col.contacts[0];
        
        if (col.gameObject.tag == "hammer")
        {
            if ((gameObject.GetComponent<Rigidbody>().isKinematic == true))
            {
				
                gameObject.GetComponent<Rigidbody>().isKinematic = false;
				GameObject aoe = Instantiate(areaOfEffect, contact.point , Quaternion.Euler(gameObject.transform.rotation.eulerAngles.x, gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z + 90));
                aoe.GetComponent<AreaOfEffect>().setSize(col.relativeVelocity.magnitude);
				Debug.Log (col.relativeVelocity.magnitude);
                //Destroy(aoe);
            }
        }
    }

}
