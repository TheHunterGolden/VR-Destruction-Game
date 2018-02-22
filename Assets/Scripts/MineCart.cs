using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineCart : MonoBehaviour {

	private Rigidbody rigidbody;
	public GameObject textHolder;

	void Start () {
		rigidbody = gameObject.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider collider) {

		if (collider.gameObject.tag == "breakable") {
			rigidbody.mass += collider.gameObject.GetComponent<Rigidbody> ().mass;
			GameObject text = Instantiate (textHolder, collider.gameObject.transform.localPosition, Quaternion.identity);
			Destroy (collider.gameObject);
		}
	}
}
