using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyEnemy : MonoBehaviour
{
    Collider2D col;
    FlyingEnemy fly;
    Rigidbody2D rb;
    public bool isEnabled;
    [SerializeField] int vida;
    int shotCounter = 0;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        col = GetComponent<Collider2D>();
        fly = GetComponentInChildren<FlyingEnemy>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        col.enabled = isEnabled;
        anim.enabled = isEnabled;
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
            Destroy(other.gameObject);
            shotCounter++;
            if (shotCounter == vida)
            {
                gameObject.SetActive(false);
                //playdeathparticles
            }
        }
    }
}
