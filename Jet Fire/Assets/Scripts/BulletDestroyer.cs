using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroyer : MonoBehaviour
{
    // Start is called before the first frame update


    // Upda
     void OnTriggerEnter2D(Collider2D other) 
     {
        if(other.CompareTag("BulletDestroyer") )
        {
            Destroy(gameObject);

        }
        
        }
    
}
