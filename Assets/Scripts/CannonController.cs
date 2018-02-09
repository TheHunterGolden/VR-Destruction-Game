﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour {
    [SerializeField]
    [Tooltip("The prefab to create shell")]
    GameObject prefabShell;

    [SerializeField]
    [Tooltip("The prefab to particle effect when shooting")]
    GameObject prefabShootingEffect;

    private float rotationSpeed;
    private float range;
    private float shootingForce;

    private void Start()
    {
        rotationSpeed = 20f;
        range = 40f;
        shootingForce = 1200f;
    }
    void Update()
    {
        var tempRot = transform.localEulerAngles;
        tempRot.y += Time.deltaTime * rotationSpeed;
        transform.localEulerAngles = tempRot;

        if (transform.localEulerAngles.y >= range && transform.localEulerAngles.y <= 360 - range)
            rotationSpeed = -rotationSpeed;
    }

    public void shootShell()
    {
        GameObject shootingEffect = Instantiate(prefabShootingEffect, transform);
        GameObject shell = Instantiate(prefabShell, transform);
        shootingEffect.transform.parent = null;
        shell.transform.parent = null;
        float unit = transform.localEulerAngles.y;
        if (unit >= 300)
            unit -= 360f;
        unit /= 40f;

        Vector3 direction = new Vector3(unit , 1f, 1.414f);
        shell.GetComponent<Rigidbody>().AddForce(direction.normalized * shootingForce);
    }
}
