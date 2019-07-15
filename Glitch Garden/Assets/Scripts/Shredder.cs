using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shredder : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collider = collision.gameObject;
        Destroy(collider);
    }

    private void Destroy(GameObject thing)
    {
        Destroy(thing);
    }
}
