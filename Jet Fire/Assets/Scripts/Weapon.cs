﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
  
public Transform firePoint;
public GameObject bulletPrefab; 
    public GameObject effect;
    public void Fire()
    
       
        {


            Shoot();
        }
       
        
    
     void Shoot()
        {
            Instantiate(bulletPrefab,firePoint.position,firePoint.rotation);
              SoundManagerScript.PlaySound("Fire");
        }
}
