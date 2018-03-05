using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{

    void Update()
    {
        int minutes = (int)Time.time / 60;
        int seconds = (int)Time.time % 60;
        gameObject.GetComponent<Text>().text = "Time: " + minutes + ":" + seconds.ToString("00");
    }
}
