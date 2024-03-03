using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FG_UIManager : FG_Element
{
    private FG_Model fG_Model;
    public TextMeshProUGUI scoreText;
    public Image healthFillImage;

    void Awake()
    {
        fG_Model = fG_Application.fG_Model;
    }

    void Update()
    {
        scoreText.text = "Score : " + fG_Model.GetScore().ToString();
        healthFillImage.fillAmount = fG_Model.GetHealth() / 100;
    }
}
