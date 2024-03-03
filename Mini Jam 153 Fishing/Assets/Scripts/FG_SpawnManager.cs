using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FG_SpawnManager : FG_Element
{
    public Transform fishView;
    public GameObject AstroidPrefab;
    public GameObject[] fishPrefabs;
    public int maxFishAmount;
    public int fishPoolCount;
    public int maxAstroidAmount;
    public int AstroidCount;


    void Start()
    {
        InvokeRepeating("SpawnFish", 2f, 4f);
        InvokeRepeating("SpawnAstroid", 5f, 5f);
    }

    void SpawnFish()
    {
        if(fishPoolCount < maxFishAmount)
        {
            int prefabIndex = Random.Range(0, fishPrefabs.Length);
            Instantiate(fishPrefabs[prefabIndex], fishView);
            fishPoolCount++;       
        }
    }
    void SpawnAstroid()
    {
        if(AstroidCount < maxAstroidAmount)
        {
            float xPos = 11.5f;
            float yPos;
            if(Random.Range(0,2) == 0) yPos = 10.5f; 
            else yPos = -10.5f;

            Vector3 spawnPos = new Vector3(Random.Range(-xPos, xPos), yPos, 0);
            Instantiate(AstroidPrefab, spawnPos, Quaternion.identity, fishView);
            AstroidCount++;       
        }
    }


}
