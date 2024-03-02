using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FG_FishView : FG_Element
{
    private FG_FishController fG_FishController { get; set; }
    void Awake()
    {
        fG_FishController = fG_Application.fG_Controller.fG_FishController;
    }

    void Start()
    {
        fG_FishController.PlaceFish(transform);
    }

    void Update()
    {
        fG_FishController.FishTraverse(transform);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Boundary"))
        {
            Debug.Log("Boundary hit!");
            fG_FishController.ChangeFishDirection(transform);
        }
    }
}
