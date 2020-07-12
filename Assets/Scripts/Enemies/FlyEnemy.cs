using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyEnemy : MonoBehaviour
{
    Collider2D col;
    FlyingEnemy fly;
    Rigidbody2D rb;
    public bool isEnabled;
    void Start()
    {
        col = GetComponent<Collider2D>();
        fly = GetComponentInChildren<FlyingEnemy>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        col.enabled = isEnabled;
        if (isEnabled)
        {
            rb.velocity = fly.rb.velocity;
            fly.isEnabled = true;
        }
        else
        {
            rb.velocity = new Vector2(0, 0);
            fly.isEnabled = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            gameObject.SetActive(false);
        }
    }
}
