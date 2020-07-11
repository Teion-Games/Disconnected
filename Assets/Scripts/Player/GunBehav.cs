using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBehav : MonoBehaviour
{
    Transform gunPoint;
    [SerializeField] GameObject bullet; 
    [SerializeField] float bulletSpeed = 10;
    void Start()
    {
        gunPoint = GameObject.Find(this.name+"/gunPoint").transform;
    }

    public void Fire()
    {
        GameObject shot = Instantiate(bullet, gunPoint.position, Quaternion.identity);
        shot.GetComponent<Rigidbody2D>().velocity = transform.TransformDirection(Vector3.right * bulletSpeed);
    }

}
