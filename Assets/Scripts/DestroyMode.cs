using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMode : MonoBehaviour
{
    public GameObject explosionEffect;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Vector3 particleSpawnPoint = other.transform.position;
        Instantiate(explosionEffect, particleSpawnPoint, Quaternion.identity);

        //Destroy() is the base function for destroying components in a scene
        //You need to specify that you are refferring to a game object.
        //Destroy(this), for instance, will destroy the component, not the object.
        //Destroy(this.gameObject) will destroy the object where this component is.
    }
}

