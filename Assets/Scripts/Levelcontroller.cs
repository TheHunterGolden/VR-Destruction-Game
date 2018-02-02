using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelcontroller : MonoBehaviour {


    public string levelName;
	// Use this for initialization
	void Start () {
        
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) { 
            Debug.Log("space key was pressed");
            SceneManager.LoadScene(levelName);
        }
    }

    void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "controller") {
            //SceneManager.LoadScene(levelName);
        }
    }

    
}
