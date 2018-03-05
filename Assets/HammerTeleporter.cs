using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerTeleporter : MonoBehaviour {

    public float timer;
    public Transform playerPos;
    public Transform teleportDestination;

    void Start() {
        timer = 3.0f;
    }

    void Update() {
        if (timer >= 0)
        {
            timer -= Time.deltaTime;
        }
    }

    void OnTriggerEnter(Collider col) {
        if ((col.gameObject.tag == "hammer") && (timer <= 0.2f)) {
            //Debug.Log("hit hammer");

			//playerPos.position = teleportDestination.position;
            teleportDestination.GetComponent<HammerTeleporter>().timer = 3.0f;

		

        }
    }


}
