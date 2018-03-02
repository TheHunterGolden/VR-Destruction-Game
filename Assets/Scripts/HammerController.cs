using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerController : MonoBehaviour {
    [SerializeField]
    [Tooltip("The prefab to particle effect when hitting using hammer")]
    GameObject prefabHammerEffect;

    private void OnCollisionEnter(Collision collision)
    {
        GameObject hittingEffect = Instantiate(prefabHammerEffect, transform);
        hittingEffect.transform.parent = null;
        hittingEffect.transform.localScale = Vector3.one;
        hittingEffect.transform.localPosition = collision.contacts[0].point;
    }
}
