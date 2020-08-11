

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

  float i=0.2f;
public GameObject enemy;
 private float timeBetweenSpawn;
//Vector2 whereToSpawn;
public float startTimeBetweenSpawn;
void Start()
{

timeBetweenSpawn=startTimeBetweenSpawn;

}
private void Update() 
{
    if(timeBetweenSpawn<=0)
    {
 
      Instantiate(enemy,transform.position,Quaternion.identity);
     
    if(i<2){
      i=i+0.1f;
    }
      timeBetweenSpawn=startTimeBetweenSpawn;
      
    }
    else 
    {

        timeBetweenSpawn-=Time.deltaTime*i;
        
    }
}


}
