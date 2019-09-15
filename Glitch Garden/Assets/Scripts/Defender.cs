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
    AttackerSpawner mySpawner;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        resourceManager = FindObjectOfType<ResourceManager>();
        animator = GetComponent<Animator>();
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
            animator.SetBool("IsAttacking", true);
        }
        else
        {
            animator.SetBool("IsAttacking", false);
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
