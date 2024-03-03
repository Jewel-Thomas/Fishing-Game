using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HookMove : MonoBehaviour
{
    public GameObject hook;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z);
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);       
            
            Debug.Log("mouse clicked: " + mousePos.ToString());

            hook.transform.DOMove(mousePos,2f,false); 
        }

        

    }
}
