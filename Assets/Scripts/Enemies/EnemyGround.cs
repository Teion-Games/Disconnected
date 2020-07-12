using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGround : MonoBehaviour
{
    bool _enabled;
    public bool enabled { get { return _enabled; } set { _enabled = value; } }
    [SerializeField] float point1, point2;
    [SerializeField] float waitTime = 1f;
    [SerializeField] float vel;
    Rigidbody2D rb;
    float waitTimeSave;
    float dir1, dir2;
    bool patrol = true;
    public bool isEnabled;
    Collider2D col;
    Animator anim;
    void Start()
    {
        col = GetComponent<Collider2D>();
        waitTimeSave = waitTime;
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
        if (Mathf.Abs(point1 - transform.position.x) <= 0.4)
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

    void Patrol2()
    {
        dir2 = Mathf.Clamp((point2 - transform.position.x), -1f, 1f);
        Vector2 moveVel = rb.velocity;
        moveVel.x = dir2 * vel;
        rb.velocity = moveVel;
        if (Mathf.Abs(point2 - transform.position.x) <= 0.4)
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


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}
