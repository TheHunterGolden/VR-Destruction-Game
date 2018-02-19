using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakSound : MonoBehaviour {
	public AudioClip[] audioClips;
	public AudioSource audioSource;

	void OnCollisionEnter(Collision col) {
		if(col.gameObject.tag == "hammer")
			audioSource.PlayOneShot (audioClips [Random.Range (0, audioClips.Length)]);
		
	}
}
