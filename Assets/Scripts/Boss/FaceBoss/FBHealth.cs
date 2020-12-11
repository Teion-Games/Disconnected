using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FBHealth : MonoBehaviour
{
    [SerializeField] float healthTotal;
    [Tooltip("HUD>BossHP>Border>hpFill")]
    [SerializeField] Image healthFill;
    float health;

    void Start()
    {
        health=healthTotal;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag=="Bullet" && GetComponent<FBDecision>().started && 
        GetComponent<FBInvulnerability>().canTakeDmg)
        {
            health -=1;
            Destroy(col.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        healthFill.fillAmount = health/healthTotal;
        //em cada fase alterar o cd de cada uma das coisas
        if(healthFill.fillAmount<=0)
        {
            GetComponent<FBDecision>().BossKilled();
        }
    }
}
