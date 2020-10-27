using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    bool _enabled;
    public bool enabled { get { return _enabled; } set { _enabled = value; } }
    float point1, point2;
    [SerializeField] float vel;
    [SerializeField] int vida;
    [SerializeField] float moveRange;
    [SerializeField] bool moveY;
    [SerializeField] float waitTime;
    float waitTimeSave;
    int shotCounter = 0;
    Rigidbody2D rb;
    bool facingRight = false;
    float dir1, dir2;
    bool patrol = true;
    public bool isEnabled;
    public bool isFollowing;
    Collider2D col;
    Animator anim;
    private GameMaster gm;
    bool isStoped = false;
    void Start()
    {
        waitTimeSave = waitTime;
        if(moveY)
        {
            point1 = transform.position.y - moveRange;
            point2 = transform.position.y + moveRange;
        }
        else
        {
            point1 = transform.position.x - moveRange;
            point2 = transform.position.x + moveRange;
        }
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        col = GetComponent<Collider2D>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if(isFollowing)
        {
            anim.enabled = true;
            rb.isKinematic = false;
            col.enabled = true;             
        }
        else
        {
            anim.enabled = isEnabled;
            rb.isKinematic = !isEnabled;
            col.enabled = isEnabled;
        }

        if (isEnabled)
        {
            ControlPatrol();
            isStoped = false;
        }
        else 
        {
            if(!isStoped)
            {
                rb.velocity = new Vector2(0, 0);
                isStoped = true;
            }
        }
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
        if(moveY)
        {
            dir1 = Mathf.Clamp((point1 - transform.position.y), -1f, 1f);
        }
        else
        {
            dir1 = Mathf.Clamp((point1 - transform.position.x), -1f, 1f);
        }
        Vector2 moveVel = rb.velocity;
        if(moveY)
        {
            moveVel.y = dir1 * vel;
            rb.velocity = moveVel;
        }
        else
        {
            moveVel.x = dir1 * vel;
            rb.velocity = moveVel;
        }

        if (dir1 < 0 && facingRight)
        {
            Flip();
        }
        else if (dir1 > 0 && !facingRight)
        {
            Flip();
        }
        if(moveY)
        {
            if(Mathf.Abs(point1 - transform.position.y) <= 0.6)
            {
                rb.velocity = new Vector2(0f, 0f);
                if (waitTime <= 0)
                {
                    waitTime = waitTimeSave;
                    patrol = false;
                }
                else
                {
                    waitTime -= Time.deltaTime;
                }
            }
        }
        else
        {
            if (Mathf.Abs(point1 - transform.position.x) <= 0.6)
            {
                rb.velocity = new Vector2(0f, 0f);
                if (waitTime <= 0)
                {
                    waitTime = waitTimeSave;
                    patrol = false;
                }
                else
                {
                    waitTime -= Time.deltaTime;
                }
            }
        } 
    }

    void Patrol2()
    {
        if(moveY)
        {
            dir2 = Mathf.Clamp((point2 - transform.position.y), -1f, 1f);
        }
        else
        {
            dir2 = Mathf.Clamp((point2 - transform.position.x), -1f, 1f);
        }
        Vector2 moveVel = rb.velocity;
        if(moveY)
        {
            moveVel.y = dir2 * vel;
            rb.velocity = moveVel;
        }
        else
        {
            moveVel.x = dir2 * vel;
            rb.velocity = moveVel;
        }

        if (dir2 < 0 && facingRight)
        {
            Flip();
        }
        else if (dir2 > 0 && !facingRight)
        {
            Flip();
        }
        if(moveY)
        {
            if(Mathf.Abs(point2 - transform.position.y) <= 0.6)
            {
               rb.velocity = new Vector2(0f, 0f);
                if (waitTime <= 0)
                {
                    waitTime = waitTimeSave;
                    patrol = true;
                }
                else
                {
                    waitTime -= Time.deltaTime;
                } 
            }
        }
        else
        {
            if (Mathf.Abs(point2 - transform.position.x) <= 0.6)
            {
                rb.velocity = new Vector2(0f, 0f);
                if (waitTime <= 0)
                {
                    waitTime = waitTimeSave;
                    patrol = true;
                }
                else
                {
                    waitTime -= Time.deltaTime;
                }
            }
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

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, moveRange);
    }
}
