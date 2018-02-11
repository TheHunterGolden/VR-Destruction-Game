using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelController : MonoBehaviour {
    public void OnHome()
    {
        SceneManager.LoadScene("UIlevel");
    }

    public void OnReset()
    {
        SceneManager.LoadScene("PushTheButton");
    }
}
