using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineCart : MonoBehaviour {

	private Rigidbody rigidbody;
	//public GameObject textHolder;

	void Start () {
		rigidbody = gameObject.GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider collider) {

		if (collider.gameObject.tag == "breakable") {
			rigidbody.mass += collider.gameObject.GetComponent<Rigidbody> ().mass;
			//Instantiate (textHolder, collider.gameObject.transform.position, Quaternion.identity);
			Destroy (collider.gameObject);
		}
	}
}
