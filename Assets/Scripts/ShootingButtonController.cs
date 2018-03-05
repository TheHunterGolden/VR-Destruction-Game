using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShootingButtonController: MonoBehaviour
{
    [SerializeField]
    [Tooltip("The controller of cannon")]
    CannonController cannon;

    private float height;
    private float currentTime;

    private void Start()
    {
        height = transform.localPosition.y;
        currentTime = 0f;
    }

    private void Update()
    {
        if(height - transform.localPosition.y >= 0.15f && (currentTime == 0f || Time.time - currentTime >= 2f))
        {
            cannon.shootShell();
            currentTime = Time.time;
        }

        if(transform.localPosition.y > height)
        {
            Vector3 position = transform.localPosition;
            position.y = height;
            transform.localPosition = position;
        }
    }
}