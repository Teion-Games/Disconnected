using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceBossPlataform : MonoBehaviour
{
    [SerializeField] float scrollVel;
    Rigidbody2D rb;
    float scrollPhaseDuration;
    float scrollPhaseDurationSave;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        scrollPhaseDuration = FindObjectOfType<FaceBoss>().scrollPhaseDuration;
        scrollPhaseDurationSave = scrollPhaseDuration;
    }

    
    void Update()
    {
        if(transform.position.y>= 21.95f)
        {
            transform.position = new Vector3(transform.position.x, -1f, -1.2f);
        }
        if (FindObjectOfType<FaceBoss>().isScrolling)
        {
            MovePlataform();
        }
    }

    void MovePlataform()
    {
        if(scrollPhaseDuration<=0)
        {
            rb.velocity = new Vector2(0f, 0f);
            scrollPhaseDuration = scrollPhaseDurationSave;
            FindObjectOfType<FaceBoss>().isScrolling = false;
        }
        else
        {
            scrollPhaseDuration -= Time.deltaTime;
            Vector2 moveVel = rb.velocity;
            moveVel.y = scrollVel;
            rb.velocity = moveVel;
        }
    }
}
