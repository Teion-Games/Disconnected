using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPhaseStart : MonoBehaviour
{
    [SerializeField] Vector3 secondStart;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.transform.position = secondStart;
        }
    }
}
