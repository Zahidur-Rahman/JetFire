

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{  public int health =1;
public int playerDamage=20;
public float maxSpeed;



//public HealthBar healthBar;
public GameObject effect;
 void Start() {
    
   
}


    // Update is called once per frame
    private void Update()
{
       
        transform.Translate( Vector2.left *maxSpeed* Time.deltaTime);
        
    

   

    }
    void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player") )
        {
            Instantiate(effect,transform.position,Quaternion.identity);
            other.GetComponent<Player>().currentHealth-=playerDamage;
              SoundManagerScript.PlaySound("PlayerDamage");
            
          Die();


        }
        else if(other.CompareTag("Left"))
        {

           
            Die();


        }
        else if(other.CompareTag("Bullet"))
        {  
            SoundManagerScript.PlaySound("EnemyHit");
           GameDataManager.SetScore(1);
         
            Die();
           
            

        }
            
    
}
	public void TakeDamage (int damage)
	{
		health -= damage;

		if (health <= 0)
		{
			Die();
		}
	}

	void Die ()
	{
		
		Destroy(gameObject);
	}

}
