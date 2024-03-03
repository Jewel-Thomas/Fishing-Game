using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class hookmechanic : MonoBehaviour
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
            Player.transform.DOMove(fish.transform.position,2f,false);
            Fish_Caught = false;
            //Invoke()
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Fish"))
        {
            Fish_Caught = true;
            fish = other.gameObject;
        }
    }

    void resetHook()
    {
        transform.position = Player.transform.position;
    }

}