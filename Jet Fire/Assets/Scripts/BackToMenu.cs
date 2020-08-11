using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackToMenu : MonoBehaviour
{
     public void Back()
    {   GameDataManager.finalScore=0;
     SoundManagerScript.PlaySound("Button1");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }
}
