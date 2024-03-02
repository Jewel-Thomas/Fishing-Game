using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FG_PlayerController : FG_Element
{
    public float playerRotSpeed;
    private float horizontalInput { get; set; } 

    public void AstroRotation(Transform playerViewTransform)
    {
        playerViewTransform.Rotate(Vector3.forward * playerRotSpeed * Time.deltaTime);
    }
}
