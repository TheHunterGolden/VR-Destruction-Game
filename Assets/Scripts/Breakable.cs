using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour {

    Transform[] allChildren;
    // Use this for initialization
    void Start () {

        allChildren = GetComponentsInChildren<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "hammer")
        {   foreach (Transform child in allChildren)
            {
                if (!child.GetComponent<Rigidbody>())
                {
                    child.gameObject.AddComponent<Rigidbody>();
                    child.GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
                    transform.DetachChildren();
                }
            }
        }
    }
}
