using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FG_SpawnManager : FG_Element
{
    public Transform fishView;
    public GameObject fishPrefab;
    public int maxFishAmount;
    public int fishPoolCount;

    void Start()
    {
        InvokeRepeating("SpawnFish", 2f, 5f);
    }

    void SpawnFish()
    {
        if(fishPoolCount < maxFishAmount)
        {
            Instantiate(fishPrefab, fishView);
            fishPoolCount++;       
        }
    }


}
