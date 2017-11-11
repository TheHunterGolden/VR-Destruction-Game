using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour {
    public Rigidbody rb;
    public float thrust;
    // Use this for initialization
    void Start () {
       rb = transform.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(transform.forward * thrust);
    }
}
