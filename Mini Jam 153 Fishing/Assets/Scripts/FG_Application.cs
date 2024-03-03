using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FG_Application : MonoBehaviour
{
   public FG_Model fG_Model;
   public FG_View fG_View;
   public FG_Controller fG_Controller;

   void Update()
   {
      if(fG_Model.GetHealth() <= 0) SceneManager.LoadScene(2);
   }
}
