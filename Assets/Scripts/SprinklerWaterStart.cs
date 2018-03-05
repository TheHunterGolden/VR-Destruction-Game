using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprinklerWaterStart : MonoBehaviour {

    public GameObject[] sprinklers;
    public GameObject panel;
    private float zPos;

    private void Start()
    {
        zPos = transform.localPosition.z;
        Physics.IgnoreCollision(GetComponent<CapsuleCollider>(), panel.GetComponent<MeshCollider>());
    }

    private void Update()
    {
        if (transform.localPosition.z < zPos)
        {
            Vector3 position = transform.localPosition;
            position.z = zPos;
            transform.localPosition = position;
        }
    }

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
