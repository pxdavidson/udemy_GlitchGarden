using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    // Variables
    [SerializeField] GameObject launcher;
    [SerializeField] GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Instantiates the var projectile at var gun's position
    public void FireProjectile()
    {
        Instantiate(projectile, launcher.transform.position, Quaternion.identity);
    }

}
