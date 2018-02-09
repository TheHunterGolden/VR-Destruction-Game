﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using VRTK.GrabAttachMechanics;

public class BreakableObject : MonoBehaviour {



	public GameObject areaOfEffect;
    public float timer;
    public bool startTimer;
    public bool destroyOverTime;
    public bool useTimer;
	private VRTK_InteractableObject objScript;
	private VRTK_FixedJointGrabAttach fixedGrabAttach;

    [SerializeField]
    [Tooltip("The prefab for particle effect when hitting the wall")]
    GameObject prefabHitEffect;

    void Start() {
        timer = 3;
        startTimer = false;
		if (gameObject.GetComponent<VRTK_InteractableObject> () && gameObject.GetComponent<VRTK_FixedJointGrabAttach> ()) { 
			objScript = gameObject.GetComponent<VRTK_InteractableObject> ();
			fixedGrabAttach = gameObject.GetComponent<VRTK_FixedJointGrabAttach> ();
			objScript.grabAttachMechanicScript = fixedGrabAttach;
		}
    }

    void Update()
    {

        if ((startTimer == true) && (useTimer)) { 
            timer -= Time.deltaTime;
            gameObject.transform.localScale -= new Vector3(0.3f, 0.3f, 0.3f);
        }

        if ((destroyOverTime == true) && (timer <= 0)) {
            Destroy(gameObject);
        }

		if (gameObject.GetComponent<Rigidbody> ().isKinematic == true && (objScript != null)) {
			objScript.enabled = false;
		}

    }

    void OnCollisionStay(Collision col) {

        ContactPoint contact = col.contacts[0];
        
        if (col.gameObject.tag == "hammer")
        {
            if ((gameObject.GetComponent<Rigidbody>().isKinematic == true))
            {
				
                gameObject.GetComponent<Rigidbody>().isKinematic = false;
				GameObject aoe = Instantiate(areaOfEffect, contact.point , Quaternion.Euler(gameObject.transform.rotation.eulerAngles.x, gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z + 90));
<<<<<<< HEAD
				aoe.GetComponentInChildren<AreaOfEffect>().setSize(col.relativeVelocity.magnitude);
				Debug.Log (col.relativeVelocity.magnitude);
                //Destroy(aoe);
=======
                aoe.GetComponent<AreaOfEffect>().setSize(col.relativeVelocity.magnitude);
                Instantiate(prefabHitEffect, contact.point, Quaternion.Euler(gameObject.transform.rotation.eulerAngles.x, gameObject.transform.rotation.eulerAngles.y, gameObject.transform.rotation.eulerAngles.z + 90));
				//Debug.Log (col.relativeVelocity.magnitude);
                Destroy(aoe);
>>>>>>> 3481de0584e343ea8ae9eece065ba96fe37a8be7
            }
        }
    }

}
