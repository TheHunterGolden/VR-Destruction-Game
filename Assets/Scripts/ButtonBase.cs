using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBase : MonoBehaviour {

    public GameObject redButton;
    //Set the time the button must be pressed.
    private float currCount;
    public bool buttonDown;

    void Start () {
        currCount = 5;
        buttonDown = false;
	}

    void FixedUpdate() {
        //Button Functionality.
      
        if (buttonDown)
        {
            if (currCount <= 1)
            {   //Button Functionality.
                Debug.Log("Pressed");
            }
            else
            {
                StartCoroutine("StartCountdown");
            }
        }
        
        else if(!buttonDown)
        {

            StopCoroutine("StartCountdown");

        }

    }

    void OnTriggerStay(Collider other)
    {

        if (other.name == redButton.name) {

            buttonDown = true;
        
        }
        
        
    }

    void OnTriggerExit(Collider other) {
        if (other.name == redButton.name) {
            
            buttonDown = false;
        }
    }


    public IEnumerator StartCountdown() {
        currCount = 5;

        while (currCount >= 0) {
            yield return new WaitForSeconds(1.0f);
            currCount--;
        }
    }
    
}
