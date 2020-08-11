using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BackToMainMenu : MonoBehaviour
{  
    public void DirectMenu()
    {  
        SoundManagerScript.PlaySound("Button1");
        GameDataManager.finalScore=0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2);
    }
    public void PlayMenu()
    {
        SoundManagerScript.PlaySound("Button1");
        GameDataManager.finalScore=0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);

    }
    public void Quit()
    {
             SoundManagerScript.PlaySound("Button1");
      Application.Quit();
    }

}
