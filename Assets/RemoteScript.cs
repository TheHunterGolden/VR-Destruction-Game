using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class RemoteScript : MonoBehaviour {

	public GameObject toEnable;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.GetComponent<VRTK_InteractableObject>().IsGrabbed()) {
			toEnable.SetActive (true);	
		}	
	}
}
