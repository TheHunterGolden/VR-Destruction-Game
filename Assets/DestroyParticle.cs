using System.Collections;
using UnityEngine;

public class DestroyParticle : MonoBehaviour {

    private void Start()
    {
        Destroy(gameObject, GetComponent<ParticleSystem>().duration);
    }
}
