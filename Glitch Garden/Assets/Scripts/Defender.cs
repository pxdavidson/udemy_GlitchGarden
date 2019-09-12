using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    // Variables
    [SerializeField] GameObject launcher;
    [SerializeField] GameObject projectile;
    [SerializeField] int starCost = 50;
    AttackerSpawner mySpawner;

    // Cache
    ResourceManager resourceManager;

    // Start is called before the first frame update
    void Start()
    {
        resourceManager = FindObjectOfType<ResourceManager>();
        SetLaneSpawner();
        PayCost();
    }

    // Update is called every frame
    private void Update()
    {
        CheckForTarget();
    }

    // Debits the cost of the defender from the Resource Manager
    public void PayCost()
    {
        resourceManager.DebitStarBal(starCost);
    }

    // Sets the defender to start and stop shooting
    private void CheckForTarget()
    {
        AttackerInLane();
        if (AttackerInLane())
        {
            Debug.Log("Pew");
        }
        else
        {
            Debug.Log("Chill");
        }
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

    // Sets the spawner in the same lane as global variable mySpawner
    private void SetLaneSpawner()
    {
        AttackerSpawner[] attackerSpawners = FindObjectsOfType<AttackerSpawner>();

        foreach (AttackerSpawner spawner in attackerSpawners)
        {
            if (Mathf.Abs(spawner.transform.position.y - this.transform.position.y) <= Mathf.Epsilon)
            {
                mySpawner = spawner;
                Debug.Log(mySpawner.name);
            }
        }
    }


    private bool AttackerInLane()
    {
        if (mySpawner.transform.childCount > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
