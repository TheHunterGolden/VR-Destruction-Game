using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{

    void Update()
    {
        gameObject.GetComponent<Text>().text = "Time: " + Time.time.ToString("0.00");
    }
}
