using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FG_Model : FG_Element
{
    private int Score { get; set; }
    private float Health { get; set; }
    public float[] orbitRadii;

    void Start()
    {
        Health = 100;
    }

    public int GetScore()
    {
        return Score;
    }

    public void SetScore(int change)
    {
        Score += change;
    }

    public float GetHealth()
    {
        return Health;
    }

    public void SetHealth(float change)
    {
        Health += change;
    }
}
