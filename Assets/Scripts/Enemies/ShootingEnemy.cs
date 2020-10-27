using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemy : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] bool isSmart;
    [SerializeField] float bulletSpeed, bulletCD;
    GameObject playerGO;
    float saveBulletCD;
    Transform gunPoint;
    void Start()
    {
        playerGO = FindObjectOfType<Player>().gameObject;
        gunPoint = GameObject.Find(this.name+"/gunPoint").transform;
        saveBulletCD = bulletCD;
        StartCoroutine(ShootingBehav(bulletCD));
    }

    private IEnumerator ShootingBehav(float shotTime)
    {
        while (true)
        {
            if(isSmart)
            {
                gunPoint.LookAt(new Vector3(playerGO.transform.position.x, playerGO.transform.position.y+2f, playerGO.transform.position.z));
                // GameObject particle = Instantiate(shotParticle, gunPoint.position, Quaternion.identity);
                // particle.GetComponent<ParticleSystem>().Play();
                GameObject bulleto = Instantiate(bullet, gunPoint.position, Quaternion.identity);
                bulleto.GetComponent<Rigidbody2D>().velocity = gunPoint.forward * bulletSpeed;
            }
            else
            {
                // GameObject particle = Instantiate(shotParticle, gunPoint.position, Quaternion.identity);
                // particle.GetComponent<ParticleSystem>().Play();
                GameObject bulleto = Instantiate(bullet, gunPoint.position, Quaternion.identity);
                bulleto.GetComponent<Rigidbody2D>().velocity = gunPoint.up * bulletSpeed;
            }
            yield return new WaitForSeconds(shotTime);
        }
    }
}
