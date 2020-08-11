
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {  
       SoundManagerScript.PlaySound("Button1");
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
   
    }
        public void Credit()
    {  
       SoundManagerScript.PlaySound("Button1");
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+3);
   
    }
    public void QuitGame()
    {  
     SoundManagerScript.PlaySound("Button1");
      Application.Quit();
      
    }
}
