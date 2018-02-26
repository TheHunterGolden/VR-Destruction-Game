using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDetection : MonoBehaviour
{
    private float startTime;
    private bool pressed;

    [SerializeField]
    [Tooltip("The score gameobject")]
    GameObject scoreObject;

    private void Start()
    {
        startTime = 0;
        pressed = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!pressed && collision.gameObject.tag == "ButtonBase")
            startTime = Time.time;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (!pressed && collision.gameObject.tag == "ButtonBase")
            startTime = 0;
    }

    private void OnCollisionStay(Collision collision)
    {
        if (!pressed && collision.gameObject.tag == "ButtonBase")
        {
            if (Time.time - startTime == 3f)
            {
                scoreObject.GetComponent<Score>().addScore();
                Debug.Log("pressed for 3 sec");
                pressed = true;
            }
        }
    }
}
