using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBehav : MonoBehaviour
{
    Transform gunPoint;
    [SerializeField] GameObject bullet;
    [SerializeField] float bulletSpeed = 10;
    [SerializeField] float gunCD = 2f;
    float savegunCD;
    public bool shooting = false;
    [SerializeField] GameObject shotParticle;
    void Start()
    {
        savegunCD = gunCD;
        gunPoint = GameObject.Find(this.name + "/gunPoint").transform;
    }

    void Update()
    {
        gunCD -= Time.deltaTime;
        if (gunCD <= 0)
        {
            shooting = true;
        }
        else shooting = false;
    }
    public void Fire()
    {
        if (gunCD <= 0)
        {
            AudioManager.instance.PlaySound("Fire");
            GameObject shot = Instantiate(bullet, gunPoint.position, Quaternion.identity);
            GameObject particle = Instantiate(shotParticle, gunPoint.position, Quaternion.identity);
            particle.GetComponent<ParticleSystem>().Play();
            shot.GetComponent<Rigidbody2D>().velocity = transform.TransformDirection(Vector3.right * bulletSpeed);
            gunCD = savegunCD;
            GetComponent<PlayerOverflow>().ShotIncrement();
        }
    }

}
