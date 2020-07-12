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
    bool facingRight = true;
    GameMaster gm;
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
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
            fly.isEnabled = true;
            rb.velocity = fly.rb.velocity;
            if (rb.velocity.x < 0 && facingRight)
            {
                Flip();
            }
            else if (rb.velocity.x > 0 && !facingRight)
            {
                Flip();
            }

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
                GameObject destroy = Instantiate(gm.particleDestroy, transform.position, Quaternion.identity);
                destroy.GetComponent<ParticleSystem>().Play();
                gameObject.SetActive(false);
            }
        }
    }
    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}
