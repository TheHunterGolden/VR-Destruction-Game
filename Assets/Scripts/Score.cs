using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int count;

    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
		gameObject.GetComponent<Text>().text = "Buttons Pressed\n" + count + " out of 15";
    }

    public void addScore()
    {
        count++;
    }
}
