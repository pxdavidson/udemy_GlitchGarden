using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Variables
    [SerializeField] int startingHealth = 20;
    [SerializeField] GameObject deathVFX;
    int health;

    // Cache


    // Start is called before the first frame update
    void Start()
    {
        health = startingHealth;
    }

    // Process' damage from incoming objects
    public void TakeDamage(int damage)
    {
            health -= damage;
            CheckHealth();
    }

    // Check the health
    private void CheckHealth()
    {
        if (health <= 0)
        {
            Die();
        }
        else
        {
            // Do nothing
        }
    }

    // Shred (with Destroy()) this gameObject
    private void Die()
    {
        Instantiate(deathVFX, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
