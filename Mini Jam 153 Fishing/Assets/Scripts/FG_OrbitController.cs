using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FG_OrbitController : FG_Element
{
    public int segments = 64;

    void Update()
    {

    }

    public void UpdateCircle(LineRenderer lineRenderer, float orbitRadius)
    {
        float angleStep = 2f * Mathf.PI / segments;
        lineRenderer.positionCount = segments;

        for(int i=0; i < segments; i++)
        {
            float xPosition = orbitRadius * Mathf.Cos(angleStep * i);
            float yPosition = orbitRadius * Mathf.Sin(angleStep * i);

            Vector3 pointInCircle = new Vector3(xPosition, yPosition, 0);

            lineRenderer.SetPosition(i, pointInCircle);
        }
    }
}
