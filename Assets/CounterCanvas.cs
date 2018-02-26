using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class CounterCanvas : MonoBehaviour {
	public GameObject playArea;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (playArea.GetComponent<VRTK_HeadsetControllerAware> ().LeftControllerGlanced ())
			gameObject.GetComponent<Canvas> ().enabled = true;
		else
			gameObject.GetComponent<Canvas> ().enabled = false;
	}
}
