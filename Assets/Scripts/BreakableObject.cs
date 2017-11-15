using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BreakableObject : MonoBehaviour {



    public GameObject areaOfEffect;


    void OnCollisionEnter(Collision col) {

        ContactPoint contact = col.contacts[0];
        
        if (col.gameObject.tag == "hammer")
        {
            if ((col.relativeVelocity.magnitude > 1) && (gameObject.GetComponent<Rigidbody>().isKinematic == true))
            {
     
                gameObject.GetComponent<Rigidbody>().isKinematic = false;
                GameObject aoe = Instantiate(areaOfEffect, contact.point, Quaternion.Euler(gameObject.transform.rotation.eulerAngles.x, gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z + 90));
                aoe.GetComponent<AreaOfEffect>().setSize(col.relativeVelocity.magnitude);
                Destroy(aoe);
            }
        }
    }
}
