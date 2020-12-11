using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingMissile : MonoBehaviour
{
    Transform target;
    Rigidbody2D rb;
    [SerializeField] float speed = 5f;
    [SerializeField] float rotationSpeed = 200f;
    [SerializeField] float missileDurationBeforeDestroy = 2f; 
    Vector2 direction;
    void Start()
    {
        target = GameObject.Find("Player").transform;
        rb = GetComponent<Rigidbody2D>();
        Invoke("DestroyMissile", missileDurationBeforeDestroy);
    }


    void FixedUpdate()
    {
        CalculateDirection();
        FollowTarget();
    }

    void CalculateDirection()
    {
        direction = new Vector2(target.position.x, target.position.y+3) - rb.position;
        direction.Normalize();
    }

    void FollowTarget()
    {
        float rotationAmount = Vector3.Cross(direction, transform.up).z;

        rb.angularVelocity = -rotationAmount * rotationSpeed;
        rb.velocity = transform.up * speed;
    }

    void DestroyMissile()
    {
        Destroy(gameObject);
    }
}
