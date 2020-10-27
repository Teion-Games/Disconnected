using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    Transform playerTrans;
    bool canFollow=false;
    Transform tagGround;
    bool inSight, inGround;
    [SerializeField] LayerMask groundMask;
    [SerializeField] float followVel;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tagGround = GameObject.Find(this.name+"/tagGround").transform;
        playerTrans = FindObjectOfType<Player>().GetComponent<Transform>();
        
    }

    void Update()
    {
        if(inGround && inSight)
        {
            GetComponent<EnemyPatrol>().isEnabled = false;
            GetComponent<EnemyPatrol>().isFollowing = true;
            float dir = Mathf.Clamp((playerTrans.position.x - transform.position.x), -1f, 1f);
            Follow(dir);
        }
        else
        {
            GetComponent<EnemyPatrol>().isEnabled = true;
            GetComponent<EnemyPatrol>().isFollowing = false;
        }
    }

    void FixedUpdate()
    {
        if (Physics2D.Linecast(new Vector3(transform.position.x, transform.position.y+2f, transform.position.z), tagGround.position, groundMask))
		{
            inGround = true;
        }
        else
        {
            inGround = false;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player")
        {
            inSight = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player")
        {
            inSight = false;
        }
    }

    void Follow(float direct)
    {
        Vector2 moveVel = rb.velocity;
        moveVel.x = direct * followVel;
        rb.velocity = moveVel;
    }

}
