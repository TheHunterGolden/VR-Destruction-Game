using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorWhite : MonoBehaviour {

	private Image image;
	// Use this for initialization
	void Start () {
		image = gameObject.GetComponent<Image> ();	
		image.color = Color.white;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
