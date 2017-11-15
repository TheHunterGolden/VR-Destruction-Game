using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaOfEffect : MonoBehaviour {

  

    //if it reaches a breakable object, it turns the rigidbody off kinematic
    void OnTriggerEnter(Collider col) {

        if (col.gameObject.tag == "breakable")
        {
            if (col.gameObject.GetComponent<Rigidbody>().isKinematic == true)
            {

                col.gameObject.GetComponent<Rigidbody>().isKinematic = false;

            }
        }

    }

    public void setSize(float size) {

        gameObject.transform.localScale = new Vector3(size, gameObject.transform.localScale.y, size);

    }
}
