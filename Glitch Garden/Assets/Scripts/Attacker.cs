using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    // Define variables
    [ Range (0f, 3f)] [SerializeField] float moveSpeed = 1f;
    [SerializeField] int startingHealth = 20;
    [SerializeField] GameObject deathVFX;
    int health;

    // Cache
    Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        health = startingHealth;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }

    // Sets the moveSpeed when called.
    public void SetMoveSpeed(float speed)
    {
        moveSpeed = speed;
    }

    // Detect collisions with other objects
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collider = collision.gameObject;
        ProcessDamage(collider);
    }

    // Process' damage from incoming objects
    private void ProcessDamage(GameObject collider)
    {
        if (collider.gameObject.tag == "Projectile")
        {
            int damageTaken = collider.GetComponent<Projectile>().ReturnDamageValue();
            health = (health - damageTaken);
            CheckHealth();
            Destroy(collider.gameObject);
        }
        else
        {
            // Do nothing
        }
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

    // Sets Animation to be attacking
    public void Attacking(GameObject target)
    {
        animator.SetBool("IsAttacking", true);
        Debug.Log(target.name);
    }
}
