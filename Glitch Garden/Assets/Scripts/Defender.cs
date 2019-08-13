using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    // Variables
    [SerializeField] GameObject launcher;
    [SerializeField] GameObject projectile;
    [SerializeField] int starCost = 50;

    // Cache
    ResourceManager resourceManager;

    // Start is called before the first frame update
    void Start()
    {
        resourceManager = FindObjectOfType<ResourceManager>();
        PayCost();
    }

    // Debits the cost of the defender from the Resource Manager
    public void PayCost()
    {
        resourceManager.DebitStarBal(starCost);
    }

    // Instantiates the var projectile at var gun's position
    public void FireProjectile()
    {
        Instantiate(projectile, launcher.transform.position, Quaternion.identity);
    }
    // Returns the Star Cost
    public int ReportStarCost()
    {
        return starCost;
    }
}
