using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HookMove : MonoBehaviour
{
    public Vector2 target, mousePos;
    public GameObject hook;
    public Camera maincam;
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) // mouse click is registered but i get weird values regardless of where i click
        {
            mousePos = maincam.ScreenToWorldPoint(Input.mousePosition);            
            
            Debug.Log("mouse clicked: " + mousePos.ToString()); // this returns the same values every time
            //mousePos.z=transform.position.z;
            hook.transform.DOMove(mousePos,2f,false); 

        }

        //hook.transform.position = Vector3.MoveTowards(transform.position,target, speed * Time.deltaTime); //This just doesnt work
        //DOTWeen moves the object

    }
}
