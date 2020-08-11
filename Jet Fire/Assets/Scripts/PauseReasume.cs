using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class PauseReasume : MonoBehaviour
{
   public GameObject PausedScene;
   public GameObject pause;
   bool GamePaused;

    void Start()
    {
        GamePaused=false;

    }

    // Update is called once per frame
    void Update()
    {
        if(GamePaused){
        Time.timeScale=0;
        }
        else{
        Time.timeScale=1;
        }
    }
    public void PauseGame()
    {SoundManagerScript.PlaySound("Button1");
        GamePaused = true;
        PausedScene.SetActive(true);
        pause.SetActive(false);


    }
    public void ResumeGame()
    {
        SoundManagerScript.PlaySound("Button1");
      GamePaused = false;
       PausedScene.SetActive(false);
       pause.SetActive(true);

    }
  public void Quit()
    {

             SoundManagerScript.PlaySound("Button1");
      Application.Quit();
    }
      public void Menu()
    {

         GameDataManager.finalScore=0;
     SoundManagerScript.PlaySound("Button1");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }

}
