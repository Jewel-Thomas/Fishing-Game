using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FG_Element : MonoBehaviour
{
    public FG_Application fG_Application { get { return FindFirstObjectByType<FG_Application>(); } }
}
