using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FG_PlayerView : FG_Element
{
    private FG_PlayerController playerViewController;

    void Awake()
    {
        playerViewController = fG_Application.fG_Controller.fG_PlayerController;
    }
    void Update()
    {
        playerViewController.AstroRotation(transform);
    }
}
