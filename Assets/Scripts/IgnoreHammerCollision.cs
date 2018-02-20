using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreHammerCollision : MonoBehaviour {

	public GameObject objColIgnored;

	// Use this for initialization
	void Start () {
		Physics.IgnoreCollision (objColIgnored.GetComponent<MeshCollider> (), GetComponent<BoxCollider> ());
	}
	
	void OnCollisionEnter (Collision col) {
	
		if (col.gameObject.tag == "hammer") {
			Debug.Log ("Hitting Hammer");
			Physics.IgnoreCollision (col.gameObject.GetComponent<Collider>(), GetComponent<Collider>());
		
		}
	
	}


}
