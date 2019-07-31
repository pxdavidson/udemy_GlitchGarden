using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    // Variables
    [SerializeField] GameObject launcher;
    [SerializeField] GameObject projectile;
    [SerializeField] int StarCost = 50;

    // Cache


    // Debits the cost of the defender from the Resource Manager
    public void PayCost()
    {
        
    }

    // Instantiates the var projectile at var gun's position
    public void FireProjectile()
    {
        Instantiate(projectile, launcher.transform.position, Quaternion.identity);
    }

}
