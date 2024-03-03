using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FG_AstroidController : FG_Element
{
    [SerializeField] GameObject playerObject;
    private Rigidbody astroidRb;
    public float fallSpeed;
    private FG_Model fG_Model;

    void Awake()
    {
        fG_Model = fG_Application.fG_Model;
    }
    void Start()
    {
        playerObject = FindFirstObjectByType<FG_PlayerView>().gameObject;
        astroidRb = GetComponent<Rigidbody>();
        MoveTowardsPlayer();
    }   

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 20 * Time.deltaTime);
    }

    void MoveTowardsPlayer()
    {
        Vector3 directionTowardsPlayer = playerObject.transform.position - transform.position;
        astroidRb.AddForce(directionTowardsPlayer * fallSpeed * Time.deltaTime, ForceMode.Impulse);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("AstroidKill") || other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            fG_Application.fG_Controller.fG_SpawnManager.AstroidCount--;
            fG_Model.SetHealth(-12.5f);
        }
    }
}
