using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StelagtiteController : MonoBehaviour {
	public GameObject glowingEffect;

	// Use this for initialization
	void Start () {
		GameObject glowing = Instantiate (glowingEffect, transform);
		Vector3 scale = transform.localScale;
		//Vector3 position = transform.localPosition;
		Quaternion rotation = transform.localRotation;
		glowing.transform.parent = null;
		glowing.transform.localScale = scale;
		glowing.transform.localRotation = rotation;
		//glowing.transform.localPosition = position.

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
