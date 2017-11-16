using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour {

    public GameObject areaOfEffect;
    ContactPoint contact;



    void Update () {
		
	}

    void OnCollisionEnter(Collision col) {

        contact = col.contacts[0];

        //Debug.Log("relative velocity: " + col.relativeVelocity.magnitude);
        if (col.gameObject.tag == "breakable")
        {   
            //Instantiate (areaOfEffect, contact.point, areaOfEffect.transform.localRotation);
            Debug.Log("contact point:" + contact.point);
        }

    }

    void OnTriggerEnter(Collider collider) {
        if (collider.gameObject.tag == "breakable") {
            //GameObject aoe = Instantiate(areaOfEffect, contact.point, areaOfEffect.transform.localRotation);
            //Destroy(aoe);
            Debug.Log("trigger");
        }
    }
}
