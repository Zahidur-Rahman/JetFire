using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawnerScript : MonoBehaviour
{ 
    
       public GameObject coins;
     private float timeBetweenSpawn;
//Vector2 whereToSpawn;
public float startTimeBetweenSpawn;
float j =0.4f;
void Start()
{
  timeBetweenSpawn=startTimeBetweenSpawn;
}
private void Update() 
{
    if(timeBetweenSpawn<=0)
    {
 
      Instantiate(coins,transform.position,Quaternion.identity);
      if(j<2){
      j=j+0.2f;
      }
      timeBetweenSpawn=startTimeBetweenSpawn;
    }
    else 
    {

        timeBetweenSpawn-=Time.deltaTime*j;

    }
}


}


