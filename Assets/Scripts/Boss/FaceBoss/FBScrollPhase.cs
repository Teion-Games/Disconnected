using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FBScrollPhase : MonoBehaviour
{
    [SerializeField] float scrollVel;
    [SerializeField] Rigidbody2D[] plataformsToMove;
    [SerializeField] float scrollPhaseDuration;


    
    void Update()
    {
        if(transform.position.y>= 21.95f)
        {
            transform.position = new Vector3(transform.position.x, -1f, -1.2f);
        }
    }

    public IEnumerator MovePlataforms()
    {
        foreach (Rigidbody2D plataform in plataformsToMove)
        {
            Vector2 moveVel = plataform.velocity;
            moveVel.y = scrollVel;
            plataform.velocity = moveVel;
        }
        yield return new WaitForSeconds(scrollPhaseDuration);
        foreach (Rigidbody2D plataform in plataformsToMove)
        {
            plataform.velocity = new Vector2(0f, 0f);
        }
    }

}
