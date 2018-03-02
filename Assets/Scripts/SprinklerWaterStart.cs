using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprinklerWaterStart : MonoBehaviour {

    public GameObject[] sprinklers;

    void OnCollisionEnter(Collision col) {

        if (col.gameObject.tag == "hammer") {
            foreach (GameObject sprinkler in sprinklers) {
                if (sprinkler.GetComponent<SprinklerBehavior>().activated == true) {
                    sprinkler.GetComponent<SprinklerBehavior>().startWater();
                }
            }
        }
    }
}
