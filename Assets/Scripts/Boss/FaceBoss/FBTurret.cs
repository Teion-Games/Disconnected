using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FBTurret : MonoBehaviour
{
    ShootingEnemy[] turretScript;
    [SerializeField] float timeBetweenShotsNormal=5f, timeBetweenShotsBoosted=2f;
    [SerializeField] float boostFireRateDuration;
    
    void Start()
    {
        turretScript = FindObjectsOfType<ShootingEnemy>();
    }

    
   public IEnumerator BoostFireRate()
   {
       foreach (ShootingEnemy turret in turretScript)
       {
            turret._timeBetweenShots = timeBetweenShotsBoosted;   
       }
       yield return new WaitForSeconds(boostFireRateDuration);
       foreach (ShootingEnemy turret in turretScript)
       {
            turret._timeBetweenShots = timeBetweenShotsNormal;
       }
   }
}
