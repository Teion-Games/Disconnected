using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyEnemy : MonoBehaviour
{
    FlyingEnemy fly;
    Rigidbody2D rb;
    void Start()
    {
        fly = GetComponentInChildren<FlyingEnemy>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = fly.rb.velocity;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Bullet")
        {
            Destroy(gameObject);
        }
    }
}
