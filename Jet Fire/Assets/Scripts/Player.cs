
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Player : MonoBehaviour
{
public static int finalScore=0;
public int maxHealth=100; 
public int currentHealth;  
public float maxHeight;
public float minHeight;
 public float speed;
public Vector2 yPos;
public float yIncrement;
public Animator animator;
public HealthBarScript healthBar;
bool up;
bool down;
 void Start() {


   yPos= new Vector2(3f,0);
     currentHealth=maxHealth;
     healthBar.SetMaxHealth(maxHealth);
              }
  private void Update()
    {    if(currentHealth<=0)
    {   
        
           
         SoundManagerScript.PlaySound("PlayerDamage");
  
         DestroyPlayer(); 
           //SoundManagerScript.PlaySound("PlayerDamage");
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    if(up)
    {

        Up();
    }
    if(down)
    {
        Down();
    }
    healthBar.SetHealth(currentHealth);
        

     transform.position =Vector2.MoveTowards( transform.position,yPos,speed*Time.deltaTime);
        

        
      
    }

   void DestroyPlayer()
    {

        
        Destroy(gameObject);


        
        
    }
    public void Up()
    {
                if(transform.position.y<maxHeight)
        {         

               yPos= new Vector2(transform.position.x+0,transform.position.y+yIncrement);
             
               animator.SetTrigger("Start");
              
           
        }
    }
    public void Down()
    {

           if(transform.position.y>minHeight)
        {

               yPos= new Vector2(transform.position.x-0 ,transform.position.y-yIncrement);
               animator.SetTrigger("Start");
        }
    }
        public void pointerDownU()
    {

 up = true;
    }
        public void pointerUpU()
    {

        up = false;

    }
           public void pointerDownD()
    {

 down = true;
    }
        public void pointerUpD()
    {

        down = false;

    }
}

