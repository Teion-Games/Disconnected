using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemy : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] float bulletSpeed, bulletCD;
    float saveBulletCD;
    Transform gunPoint;
    void Start()
    {
        gunPoint = GameObject.Find(this.name+"/gunPoint").transform;
        saveBulletCD = bulletCD;
        StartCoroutine(ShootingBehav(bulletCD));
    }

    private IEnumerator ShootingBehav(float shotTime)
    {
        while (true)
        {
            // GameObject particle = Instantiate(shotParticle, gunPoint.position, Quaternion.identity);
            GameObject bulleto = Instantiate(bullet, gunPoint.position, Quaternion.identity);
            bulleto.GetComponent<Rigidbody2D>().velocity = gunPoint.up * bulletSpeed;
            yield return new WaitForSeconds(shotTime);
        }
    }
}
