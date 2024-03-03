using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FG_SpawnManager : FG_Element
{
    public Transform fishView, AstroidView;
    public GameObject fishPrefab,AstroidPrefab;
    public int maxFishAmount;
    public int fishPoolCount;
    public int maxAstroidAmount;
    public int AstroidCount;

    void Start()
    {
        InvokeRepeating("SpawnFish", 2f, 5f);
        InvokeRepeating("SpawnAstroid", 5f, 5f);
    }

    void SpawnFish()
    {
        if(fishPoolCount < maxFishAmount)
        {
            Instantiate(fishPrefab, fishView);
            fishPoolCount++;       
        }
    }
    void SpawnAstroid()
    {

        if(AstroidCount < maxAstroidAmount)
        {
            Instantiate(AstroidPrefab, AstroidView);
            AstroidCount++;       
        }
    }


}
