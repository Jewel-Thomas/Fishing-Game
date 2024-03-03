using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HookMove : FG_Element
{
    public GameObject hook,Player;
    public float Timer;
    public TrailRenderer trailRenderer;
    public hookmechanic hookmechanic;
    private AudioManager audioManager;
    // Start is called before the first frame update

    void Awake()
    {
        audioManager = fG_Application.fG_Controller.audioManager;
    }   

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Timer = 1;
            audioManager.sfxAudioSource.PlayOneShot(audioManager.grapplingClip);
            trailRenderer.enabled = true;
            hookmechanic.GetComponent<Collider>().enabled = true;
            Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z);
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);       
            
            Debug.Log("mouse clicked: " + mousePos.ToString());

            hook.transform.DOMove(mousePos,0.5f,false); 
            
        }

        if(Timer <= 0)
        {
            resetHook();
            trailRenderer.enabled = false;
            hookmechanic.GetComponent<Collider>().enabled = false;          
        }
        else
        {
            Timer -= Time.deltaTime;
        }
    }
    
    void resetHook()
    {
        hook.transform.localPosition = Vector3.Lerp(hook.transform.position,Player.transform.position + 
        Player.transform.TransformVector(new Vector3(0,0,0)), 20 * Time.deltaTime);
    }

}
