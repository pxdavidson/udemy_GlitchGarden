using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    // Variables


    // Cache
    [SerializeField] GameObject defender;
    ResourceManager resourceManager;

    // Start is called before the first frame update
    void Start()
    {
        resourceManager = FindObjectOfType<ResourceManager>();
    }

    // Sets the defender object
    public void ChangeDefender(GameObject newdefender)
    {
        defender = newdefender;
    }
    
    // Detects mouse click
    private void OnMouseDown()
    {
        CheckStarBalance(ReturnMousePos());
    }

    // Gets the world position of the mouse
    private Vector2 ReturnMousePos()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        int newX = Mathf.RoundToInt(worldPos.x);
        int newY = Mathf.RoundToInt(worldPos.y);
        return new Vector2(newX, newY);
    }

    // Checks whether there is enough Star Balance to spawn the defender
    private void CheckStarBalance(Vector2 spawnPos)
    {
        var currentStarBal = resourceManager.ReportStarBal();
        if (currentStarBal > defender.GetComponent<Defender>().ReportStarCost())
        {
            SpawnDefender(spawnPos);
        }
        else
        {
            // DO nothing
        }
    }

    // Spawns a defender at the mouse position
    private void SpawnDefender(Vector2 spawnPos)
    {
        Instantiate(defender, spawnPos, Quaternion.identity);
    }
}
