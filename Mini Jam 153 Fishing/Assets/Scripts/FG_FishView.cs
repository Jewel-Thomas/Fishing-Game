using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FG_FishView : FG_Element
{
    private FG_FishController fG_FishController { get; set; }
    private Rigidbody fishViewRb { get; set; }
    private float timer;

    void Awake()
    {
        timer = 3;
        fG_FishController = fG_Application.fG_Controller.fG_FishController;
        fishViewRb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        fG_FishController.PlaceFish(transform);
    }

    void Update()
    {
        if(timer <= 0)
        {
            fG_FishController.FishTraverse(transform, fishViewRb);
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
