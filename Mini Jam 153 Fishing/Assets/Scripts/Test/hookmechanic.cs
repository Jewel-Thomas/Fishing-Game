using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class hookmechanic : FG_Element
{
    public static bool Fish_Caught;
    public GameObject Player, fish;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Fish_Caught)
        {
            Destroy(fish,2f);
            fG_Application.fG_Controller.fG_SpawnManager.fishPoolCount--;
            Player.transform.DOMove(fish.transform.position,4f,false);
            Fish_Caught = false;
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Fish"))
        {
            Fish_Caught = true;
            fish = other.gameObject;
            fish.GetComponent<FG_FishView>().isCaught = true;
        }
    }


}
