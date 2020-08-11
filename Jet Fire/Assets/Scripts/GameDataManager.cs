
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameDataManager{
private static int score=0;
public static int finalScore;

public static int GetScore()
{  
    
  
       
	return finalScore;
 
}
public static void SetScore(int s)
{
	score = s;
    finalScore=score+finalScore;
}
}