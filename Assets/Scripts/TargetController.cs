using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour {
    [SerializeField]
    [Tooltip("The prefab to particle effect when hit")]
    GameObject prefabExplosionEffect;

    private void OnCollisionEnter(Collision collision)
    {
        GameObject explosion = Instantiate(prefabExplosionEffect, transform);
        explosion.transform.parent = null;
        explosion.transform.localScale = Vector3.one;
        explosion.transform.localPosition = transform.localPosition;
        if (collision.gameObject.tag == "Shell")
            Destroy(collision.gameObject);

        Destroy(gameObject);
    }
}
