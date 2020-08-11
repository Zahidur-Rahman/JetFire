using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundManagerScript : MonoBehaviour
{
  public static AudioClip fireSound,enemyHitSound,button,coinHit,playerDie;
  public static AudioSource audioSrc;

    void Start()
    {
        enemyHitSound =Resources.Load<AudioClip>("EnemyHit");
        fireSound =Resources.Load<AudioClip>("Fire");
          button=Resources.Load<AudioClip>("Button1");
           coinHit=Resources.Load<AudioClip>("Coins");
            playerDie=Resources.Load<AudioClip>("PlayerDamage");

          audioSrc=GetComponent<AudioSource>();   
          
     }

    void Update()
    {
        
    }
    public static void PlaySound(string clip)
    {
       switch(clip)
       {
          case "Fire":
          audioSrc.PlayOneShot(fireSound);
          break;
              case "EnemyHit":
          audioSrc.PlayOneShot(  enemyHitSound );
          break;
            case "Button1":
          audioSrc.PlayOneShot(button);
          break;
                case "Coins":
          audioSrc.PlayOneShot(coinHit);
          break;
                case "PlayerDamage":
          audioSrc.PlayOneShot(playerDie);
          break;
          

       }
    }
}
