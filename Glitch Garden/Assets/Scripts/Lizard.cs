using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour
{
    // Variables
    
    // Cache

    // Triggered when another collider enters this trigger collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
         GameObject currentTarget = collision.gameObject;
        if (currentTarget.GetComponent<Defender>())
        {
            GetComponent<Attacker>().Attacking(currentTarget);
        }
    }


}
