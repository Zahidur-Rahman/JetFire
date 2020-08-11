
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreProcessing : MonoBehaviour
{
public Text score1;
public static int score;

public void Update() 
{


score =GameDataManager.GetScore();

score1.text=score.ToString();

}

}
