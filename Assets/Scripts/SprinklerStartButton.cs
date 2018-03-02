using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprinklerStartButton : MonoBehaviour {

    public GameObject[] sprinklers;

    void OnCollisionEnter(Collision col) {

        if (col.gameObject.tag == "hammer")
        {
            foreach (GameObject sprinkler in sprinklers)
            {
                sprinkler.GetComponent<SprinklerBehavior>().activated = true;
            }
        }
    }
}
