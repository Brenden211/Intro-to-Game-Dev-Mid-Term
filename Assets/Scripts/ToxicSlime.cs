using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToxicSlime : MonoBehaviour
{
    public GameObject explosionEffect;

    private void OnTriggerEnter(Collider other)
    {
        Application.Quit();
    }
}

