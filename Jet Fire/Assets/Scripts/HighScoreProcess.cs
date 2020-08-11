using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScoreProcess : MonoBehaviour
{

    public Text score2;
    private static int fHigh;
    int highScore;
public void Update() 
{


int score =GameDataManager.GetScore();
if(score>=fHigh)
{
    highScore=score;
    score2.text=highScore.ToString();
    fHigh=highScore;
}



else
{
score2.text=fHigh.ToString();
}

}
}


