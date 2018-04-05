using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMass : MonoBehaviour {


    void OnCollisionEnter(Collision col) {
        if (col.gameObject.GetComponent<Rigidbody>()) {
            if (col.gameObject.GetComponent<Rigidbody>().mass >= 150) {
                gameObject.GetComponent<Rigidbody>().isKinematic = false;
            }
        }
    }
}
