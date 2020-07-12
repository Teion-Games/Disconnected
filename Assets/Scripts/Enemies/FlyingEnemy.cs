using UnityEngine;
using System.Collections;

public class FlyingEnemy : MonoBehaviour
{
    [SerializeField] float vel = 5f;
    [SerializeField] float rotateVel = 200f;
    public Rigidbody2D rb;
    [SerializeField] Transform[] target;
    int vTarget;
    bool reverse;
    public bool isEnabled;

    void Start()
    {
        vTarget = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (isEnabled)
        {
            Vector2 dir = (Vector2)target[vTarget].position - rb.position;
            dir.Normalize();
            float rotateAmount = Vector3.Cross(dir, transform.up).z;

            rb.angularVelocity = -rotateAmount * rotateVel;

            rb.velocity = transform.up * vel;
            if (Mathf.Abs(Vector2.Distance(target[vTarget].position, rb.position)) <= 0.5f)
            {
                ChangePoint();
            }
        }
        else rb.velocity = new Vector2(0, 0);
    }

    void ChangePoint()
    {
        if (!reverse)
        {
            vTarget++;
        }
        else vTarget--;

        if (vTarget > target.Length - 1 || vTarget == -1)
        {
            reverse = !reverse;
            ChangePoint();
        }
    }
}