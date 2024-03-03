using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FG_OrbitView : FG_Element
{
    private FG_OrbitController fG_OrbitController;
    private float[] orbitRadii;
    [SerializeField] LineRenderer[] lineRenderers;

    void Awake()
    {
        fG_OrbitController = fG_Application.fG_Controller.fG_OrbitController;
    }

    void Update()
    {
        orbitRadii = fG_Application.fG_Model.orbitRadii;
        for(int i=1 ; i<=5; i++)
        {
            fG_OrbitController.UpdateCircle(lineRenderers[i-1], orbitRadii[i-1]);
        }
    }

}
