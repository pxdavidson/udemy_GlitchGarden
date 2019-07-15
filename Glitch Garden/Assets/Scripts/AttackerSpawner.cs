using System.Collections;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    //Variables
    [SerializeField] bool spawnTrue = true;
    [SerializeField] GameObject attackerPrefab;
    [SerializeField] float minSpawnrate = 1f;
    [SerializeField] float maxSpawnrate = 5f;

    // Coroutines
    Coroutine spawnAttacker;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnAttacker = StartCoroutine(SpawnAttacker());
    }

    // Call Spawn() then wait between 0-5 seconds and repeat
    IEnumerator SpawnAttacker()
    {
        while (spawnTrue)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnrate, maxSpawnrate));
            Spawn();
        }  
    }

    // Spawns an instance of the atacker GameObject
    private void Spawn()
    {
        Instantiate(attackerPrefab, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
