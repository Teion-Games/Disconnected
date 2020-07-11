using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    [SerializeField] float timeToFade;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeToFade -= Time.deltaTime;
        if(timeToFade<=0) Destroy(gameObject);
    }
}
