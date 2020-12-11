using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemy : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] bool aimAtPlayer;
    [SerializeField] float bulletSpeed, timeBetweenShots;
    public float _timeBetweenShots {set {timeBetweenShots = value;} }
    GameObject playerGO;
    Transform gunPoint;

    void Start()
    {
        playerGO = FindObjectOfType<Player>().gameObject;
        gunPoint = GameObject.Find(this.name+"/gunPoint").transform;
        StartCoroutine(ShootingBehav());
    }

    private IEnumerator ShootingBehav()
    {
        while (true)
        {
            if(aimAtPlayer)
            {
                gunPoint.LookAt(new Vector3(playerGO.transform.position.x, playerGO.transform.position.y+2f, playerGO.transform.position.z));
                // GameObject particle = Instantiate(shotParticle, gunPoint.position, Quaternion.identity);
                // particle.GetComponent<ParticleSystem>().Play();
                GameObject bullet = Instantiate(bulletPrefab, gunPoint.position, Quaternion.identity);
                bullet.GetComponent<Rigidbody2D>().velocity = gunPoint.forward * bulletSpeed;
            }
            else
            {
                // GameObject particle = Instantiate(shotParticle, gunPoint.position, Quaternion.identity);
                // particle.GetComponent<ParticleSystem>().Play();
                GameObject bullet = Instantiate(bulletPrefab, gunPoint.position, Quaternion.identity);
                bullet.GetComponent<Rigidbody2D>().velocity = gunPoint.up * bulletSpeed;
            }
            yield return new WaitForSeconds(timeBetweenShots);
        }
    }
}
