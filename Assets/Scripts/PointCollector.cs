using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCollector : MonoBehaviour {

    public GameObject points;
    public int totalPoints;
   
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnCollisionEnter(Collision col) {
       

        if (col.gameObject.tag == "breakable") {
            
            if (col.gameObject.GetComponent<Rigidbody>().isKinematic == false) { 

                GameObject pointSpawn = Instantiate(points, col.gameObject.transform.localPosition, Quaternion.identity);
                ScoreManager.score = ScoreManager.score + 10;
                col.gameObject.GetComponent<BreakableObject>().startTimer = true;
        }
    }
    }

   
}
