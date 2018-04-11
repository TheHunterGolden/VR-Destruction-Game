using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getWeight : MonoBehaviour {

	private Text text;
	public GameObject mineCart;
	// Use this for initialization
	void Start () {
		text = gameObject.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Weight: " + mineCart.GetComponent<Rigidbody> ().mass.ToString();
		if (mineCart.GetComponent<Rigidbody> ().mass >= 150) {
			text.color = Color.green;
		}
	}
}
