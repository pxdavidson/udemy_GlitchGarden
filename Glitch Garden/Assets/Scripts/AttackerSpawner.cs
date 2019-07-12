using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    //Variables
    bool spawnTrue = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Spawn Attacker
    IEnumerator SpawnAttacker()
    {
        while (true)
        {
            Debug.Log("Spawn");
            yield return new WaitForSeconds(UnityEngine.Random.Range(0f, 5f));
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
