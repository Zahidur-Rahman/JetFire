using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BackToMenuFromCredit: MonoBehaviour
{  
    public void DirectMenu()
    {  
        SoundManagerScript.PlaySound("Button1");
        GameDataManager.finalScore=0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-3);
    }

}
