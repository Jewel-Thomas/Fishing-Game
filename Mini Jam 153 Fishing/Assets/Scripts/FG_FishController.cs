using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FG_FishController : FG_Element
{
    private float fishTranversalSpeed;
    private float[] orbitRadii;
    public float spawnX;
    public float lowSpawnYMin;
    public float lowSpawnYMax;
    public float highSpawnYMin;
    public float highSpawnYMax;
    private Vector2 chosenPosition;

    void Awake()
    {
        fishTranversalSpeed = fG_Application.fG_Model.fishMovementSpeed;
        orbitRadii = fG_Application.fG_Model.orbitRadii;
    }

    public void FishTraverse(Transform fishViewTransform, Rigidbody fishViewRb)
    {
        fishTranversalSpeed = fG_Application.fG_Model.fishMovementSpeed;
        fishViewTransform.RotateAround(new Vector3(0,1,0), Vector3.forward, fishTranversalSpeed * Time.deltaTime);
    }

    // Places the fish in a sensible manner
    public void PlaceFish(Transform fishViewTransform)
    {
        if(Random.Range(0,2) == 0) chosenPosition.x = spawnX;
        else chosenPosition.x = -spawnX;
        if(Random.Range(0,2) == 0) chosenPosition.y = Random.Range(lowSpawnYMin, lowSpawnYMax);
        else chosenPosition.y = Random.Range(highSpawnYMin, highSpawnYMax);

        fishViewTransform.position = chosenPosition;

        Vector3 randomOrbit = new Vector3(orbitRadii[Random.Range(0, orbitRadii.Length)], 0, 0);
        fG_Application.fG_Model.fishMovementSpeed = 7.5f * randomOrbit.x;

        fishViewTransform.DOMove(randomOrbit, 2, false);

    }

    // Instead of spawning a new fish when it reaches to the opposite side, we can simply change it's direction inorder
    // to avoid spawn fish overhead
    public void ChangeFishDirection(Transform fishViewTransform, Rigidbody fishViewRb)
    {
        fishViewTransform.Rotate(0,180,0);
        fishViewRb.velocity = -fishViewRb.velocity;
    }

}
