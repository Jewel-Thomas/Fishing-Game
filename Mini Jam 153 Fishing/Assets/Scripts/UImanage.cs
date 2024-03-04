using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UImanage : MonoBehaviour
{
    public GameObject Main,Tutorial;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
         SceneManager.LoadScene(1);
    }
    public void HowToPlay()
    {
        Main.SetActive(false);
        Tutorial.SetActive(true);
    }
    public void Return()
    {
        Main.SetActive(true);
        Tutorial.SetActive(false); 
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }
    
}
