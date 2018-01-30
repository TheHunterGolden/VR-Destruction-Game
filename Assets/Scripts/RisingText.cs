using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RisingText : MonoBehaviour {

    public float timer;
    
    void Start() {
        timer = 3;
    }
    // Update is called once per frame
    void Update () {

        gameObject.transform.Translate(Vector3.up * Time.deltaTime/2, Space.World);
        timer -= Time.deltaTime;
        if (timer <= 0) {
            Destroy(gameObject);
        }
    }
}
