using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour {
	public AudioSource audioSource;
	public Score score;
	private bool pressed;
	public AudioClip[] clips;
	//public GameObject PressedText;

	void Start(){
		pressed = false;
	}

	public void PlayButtonSound(){
		int range = Random.RandomRange (0, clips.Length);
		audioSource.PlayOneShot (clips[range]);
	}

	void OnCollisionEnter(Collision col){
		PlayButtonSound ();

		if ((!pressed && col.gameObject.tag == "hammer" && gameObject.tag != "MineButton") || (!pressed && gameObject.tag == "MineButton" && !gameObject.GetComponent<Rigidbody> ().isKinematic && (col.gameObject.tag == "hammer" || col.gameObject.name == "Mine_Cart"))) {
			score.addScore ();
			pressed = true;
			gameObject.GetComponent<Renderer>().material.color = Color.green; 
			//GameObject buttonText = Instantiate (PressedText, transform);
		} else if (gameObject.tag == "big" && (pressed == false)) {
			score.addScore ();
			pressed = true;
			gameObject.GetComponent<Renderer>().material.color = Color.green; 
			//GameObject buttonText = Instantiate (PressedText, transform);
		}

	}
}
