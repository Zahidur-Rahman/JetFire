using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    // Start is called before the first frame update
 public float speed;
 public GameObject effect;

    private void Update()
    {
        transform.Translate( Vector2.left *speed* Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player") )
        {
            Instantiate(effect,transform.position,Quaternion.identity);
              SoundManagerScript.PlaySound("Coins");
            GameDataManager.SetScore(5);
            
          Die();


        }
        else if(other.CompareTag("Left"))
        {
             Die();
        }
    }
        
	void Die ()
	{
		
		Destroy(gameObject);
	}
}

