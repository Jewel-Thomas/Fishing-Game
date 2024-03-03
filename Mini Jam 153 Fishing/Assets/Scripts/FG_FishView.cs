using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FG_FishView : FG_Element
{
    private float[] orbitRadii;
    public bool isCaught;
    private FG_FishController fG_FishController { get; set; }
    public float fishTranversalSpeed;
    private Rigidbody fishViewRb { get; set; }
    private float timer;

    void Awake()
    {
        isCaught = false;
        timer = 3;
        fG_FishController = fG_Application.fG_Controller.fG_FishController;
        fishViewRb = GetComponent<Rigidbody>();
        orbitRadii = fG_Application.fG_Model.orbitRadii;
    }

    void Start()
    {
        fG_FishController.PlaceFish(transform);
        Vector3 randomOrbit = new Vector3(orbitRadii[Random.Range(0, orbitRadii.Length)], 0, 0);
        fishTranversalSpeed = 7.5f * randomOrbit.x * Random.Range(0.75f,1.25f);

        transform.DOMove(randomOrbit, 2, false);
    }

    void Update()
    {
        if(timer <= 0 && !isCaught)
        {
            fG_FishController.FishTraverse(transform, fishTranversalSpeed);
        }
        else
        {
            timer -= Time.time;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Boundary"))
        {
            Debug.Log("Boundary hit!");
            fG_FishController.ChangeFishDirection(transform, fishViewRb);
        }
        
    }
}
