using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour {
	public AudioSource audioSource;
	public Score score;
	private bool pressed;
	public AudioClip[] clips;
	public GameObject PressedText;

	void Start(){
		pressed = false;
	}

	public void PlayButtonSound(){
		int range = Random.RandomRange (0, clips.Length);
		audioSource.PlayOneShot (clips[range]);
	}

	void OnCollisionEnter(Collision col){
		PlayButtonSound ();

		if ((!pressed && col.gameObject.tag == "hammer") && (gameObject.tag != "MineButton") || (gameObject.tag == "MineButton" && !gameObject.GetComponent<Rigidbody>().isKinematic)) {
			score.addScore ();
			pressed = true;
            
            GameObject buttonText = Instantiate(PressedText, transform);
        }
	}
}
