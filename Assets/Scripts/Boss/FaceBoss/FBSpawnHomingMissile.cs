using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FBSpawnHomingMissile : MonoBehaviour
{
    [SerializeField] GameObject homingMissilePrefab;
   public void HomingMissileSpawn()
    {
        Instantiate(homingMissilePrefab, transform.position, Quaternion.identity);
    }
}
