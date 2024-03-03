using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FG_AstroidController : MonoBehaviour
{
    [SerializeField] GameObject playerObject;
    private Rigidbody astroidRb;
    public float fallSpeed;
    void Start()
    {
        playerObject = FindFirstObjectByType<FG_PlayerView>().gameObject;
        astroidRb = GetComponent<Rigidbody>();
        MoveTowardsPlayer();
    }   

    // Update is called once per frame
    void Update()
    {
        
    }

    void MoveTowardsPlayer()
    {
        Vector3 directionTowardsPlayer = playerObject.transform.position - transform.position;
        astroidRb.AddForce(directionTowardsPlayer * fallSpeed * Time.deltaTime, ForceMode.Impulse);
    }
}
