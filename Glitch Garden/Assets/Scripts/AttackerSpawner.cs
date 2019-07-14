using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    //Variables
    [SerializeField] bool spawnTrue = true;

    // Coroutines
    Coroutine spawnAttacker;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnAttacker = StartCoroutine(SpawnAttacker());
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
        if (!spawnTrue)
        {
            StopCoroutine(spawnAttacker);
        }
        else
        {
            // Do nothing
        }
    }
}
