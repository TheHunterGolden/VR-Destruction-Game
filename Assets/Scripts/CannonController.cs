using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour {
    [SerializeField]
    [Tooltip("The prefab to create shell")]
    GameObject prefabShell;

    [SerializeField]
    [Tooltip("The animator to button")]
    Animator button;

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

        if (button.GetBool("shoot"))
        {
            shootShell();
            button.SetBool("shoot", false);
        }
    }

    public void shootShell()
    {
        GameObject shell = Instantiate(prefabShell, transform);
        shell.transform.parent = null;
        float unit = transform.localEulerAngles.y;
        if (unit >= 300)
            unit -= 360f;
        unit /= 40f;
        //Debug.Log();
        Vector3 direction = new Vector3(unit , 1f, 1.414f);
        shell.GetComponent<Rigidbody>().AddForce(direction.normalized * shootingForce);
    }
}
