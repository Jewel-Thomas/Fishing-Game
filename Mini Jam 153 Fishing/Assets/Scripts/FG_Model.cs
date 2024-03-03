using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FG_Model : FG_Element
{
    private int Score { get; set; }
    public float[] orbitRadii;

    public int GetScore()
    {
        return Score;
    }

    public void SetScore(int change)
    {
        Score += change;
    }
}
