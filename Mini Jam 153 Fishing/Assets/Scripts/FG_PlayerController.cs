using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FG_PlayerController : FG_Element
{
    public float playerRotSpeed;
    private float horizontalInput { get; set; } 

    public void AstroRotation(Transform playerViewTransform)
    {
        horizontalInput = Input.GetAxis("Horizontal");
        playerViewTransform.Rotate(Vector3.back * playerRotSpeed * Time.deltaTime * horizontalInput);
    }
}
