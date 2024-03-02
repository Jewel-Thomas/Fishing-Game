using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FG_FishController : FG_Element
{
    private float fishTranversalSpeed;
    public float spawnX;
    public float lowSpawnYMin;
    public float lowSpawnYMax;
    public float highSpawnYMin;
    public float highSpawnYMax;
    private Vector2 chosenPosition;

    void Awake()
    {
        fishTranversalSpeed = fG_Application.fG_Model.fishMovementSpeed; 
    }

    public void FishTraverse(Transform fishViewTransform)
    {
        // TODO : Fish traversal
        fishViewTransform.Translate(Vector3.right * fishTranversalSpeed * Time.deltaTime);
    }

    // Places the fish in a sensible manner
    public void PlaceFish(Transform fishViewTransform)
    {
        if(Random.Range(0,2) == 0) chosenPosition.x = spawnX;
        else chosenPosition.x = -spawnX;
        if(Random.Range(0,2) == 0) chosenPosition.y = Random.Range(lowSpawnYMin, lowSpawnYMax);
        else chosenPosition.y = Random.Range(highSpawnYMin, highSpawnYMax);

        fishViewTransform.position = chosenPosition;
    }

    // Instead of spawning a new fish when it reaches to the opposite side, we can simply change it's direction inorder
    // to avoid spawn fish overhead
    public void ChangeFishDirection(Transform fishViewTransform)
    {
        fishViewTransform.Rotate(0,180,0);
    }

}
