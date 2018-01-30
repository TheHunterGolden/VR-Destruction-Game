using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerSpawner : MonoBehaviour
{
    public GameObject tool;
    public Transform spawnLocation;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "hammer")
        {
            Destroy(col.gameObject);
            Spawn(tool);
        }

    }

    void Spawn(GameObject tool) {
        Instantiate(tool, spawnLocation.position, Quaternion.identity);
    }

}
