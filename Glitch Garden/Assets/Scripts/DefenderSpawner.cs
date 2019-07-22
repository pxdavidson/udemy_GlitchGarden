using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    // Variables


    // Cache
    [SerializeField] GameObject defender;
    
    // Detects mouse click
    private void OnMouseDown()
    {
        SpawnDefender(ReturnMousePos());
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

    // Spawns a defender at the mouse position
    private void SpawnDefender(Vector2 spawnPos)
    {
        Instantiate(defender, spawnPos, Quaternion.identity);
    }
}
