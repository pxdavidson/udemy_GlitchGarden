﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophyShepherd : MonoBehaviour
{
    // Variables
    [SerializeField] int starGeneration = 50;
    [SerializeField] float generationRate = 3f;

    // Cache
    ResourceManager resourceManager;


    // Start is called before the first frame update
    void Start()
    {
        resourceManager = FindObjectOfType<ResourceManager>();
        Coroutine generateStarBal = StartCoroutine(GenerateStars());
    }

    // Update is called once per frame
    void Update()
    {
        // Do nothing
    }

    IEnumerator GenerateStars()
    {
        while (true)
        {
            yield return new WaitForSeconds(generationRate);
            resourceManager.CreditStarBal(starGeneration);
        }
    }
}
