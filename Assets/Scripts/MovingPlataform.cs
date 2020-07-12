using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlataform : MonoBehaviour
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
    bool isEnabled;
    Collider2D col;
    void Start()
    {
        col = GetComponent<Collider2D>();
        waitTimeSave = waitTime;
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        isEnabled = GetComponent<GroundColored>().isEnabled;
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
        GetComponent<Transform>().Translate(Vector3.right * vel * dir1 * Time.deltaTime);
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
        GetComponent<Transform>().Translate(Vector3.right * vel * dir2 * Time.deltaTime);
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

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.collider.transform.SetParent(transform);
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.collider.transform.SetParent(null);
        }
    }
}
