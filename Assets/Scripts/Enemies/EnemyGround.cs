using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGround : MonoBehaviour
{
    bool _enabled;
    public bool enabled { get { return _enabled; } set { _enabled = value; } }
    [SerializeField] float point1, point2;
    [SerializeField] float vel;
    [SerializeField] int vida;
    int shotCounter = 0;
    Rigidbody2D rb;
    bool facingRight = false;
    float dir1, dir2;
    bool patrol = true;
    public bool isEnabled;
    Collider2D col;
    Animator anim;
    private GameMaster gm;
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        col = GetComponent<Collider2D>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        anim.enabled = isEnabled;
        rb.isKinematic = !isEnabled;
        col.enabled = isEnabled;

        if (isEnabled)
        {
            ControlPatrol();
        }
        else rb.velocity = new Vector2(0, 0);
    }

    void ControlPatrol()
    {
        if (patrol)
        {
            Patrol1();
        }
        else
        {
            Patrol2();
        }
    }

    void Patrol1()
    {
        dir1 = Mathf.Clamp((point1 - transform.position.x), -1f, 1f);
        Vector2 moveVel = rb.velocity;
        moveVel.x = dir1 * vel;
        rb.velocity = moveVel;
        if (dir1 < 0 && facingRight)
        {
            Flip();
        }
        else if (dir1 > 0 && !facingRight)
        {
            Flip();
        }
        if (Mathf.Abs(point1 - transform.position.x) <= 0.4)
        {
            patrol = false;
        }
    }

    void Patrol2()
    {
        dir2 = Mathf.Clamp((point2 - transform.position.x), -1f, 1f);
        Vector2 moveVel = rb.velocity;
        moveVel.x = dir2 * vel;
        rb.velocity = moveVel;
        if (dir2 < 0 && facingRight)
        {
            Flip();
        }
        else if (dir2 > 0 && !facingRight)
        {
            Flip();
        }
        if (Mathf.Abs(point2 - transform.position.x) <= 0.4)
        {
            patrol = true;
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
                GameObject destroy = Instantiate(gm.particleDestroyEnemy, transform.position, Quaternion.identity);
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
