using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class hookmechanic : FG_Element
{
    public static bool Fish_Caught;
    public GameObject Player, fish;
    private AudioManager audioManager;
    private FG_Model fG_Model;
    // Start is called before the first frame update
    void Start()
    {
        audioManager = fG_Application.fG_Controller.audioManager;
        fG_Model = fG_Application.fG_Model;
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

    IEnumerator PickPlanetSound()
    {
        yield return new WaitForSeconds(2);
        audioManager.sfxAudioSource.PlayOneShot(audioManager.planetPickupClip);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Fish"))
        {
            Fish_Caught = true;
            fish = other.gameObject;
            StartCoroutine(PickPlanetSound());
            int scoreChange = (int) (10 + Mathf.Ceil(fish.GetComponent<FG_FishView>().fishTranversalSpeed / 118 * 20));
            fG_Model.SetScore(scoreChange);
            fish.GetComponent<FG_FishView>().isCaught = true;
        }
    }


}
