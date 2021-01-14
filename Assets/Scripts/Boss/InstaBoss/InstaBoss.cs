using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InstaBoss : MonoBehaviour
{
    
    
    [SerializeField] float healthTotal;
    [Tooltip("HUD>BossHP>Border>hpFill")]
    [SerializeField] Image healthFill;
    float health;
    bool isSecondPhase, isThirdPhase;
    bool started = false;

    void Start()
    {
        health=healthTotal;
        //toque a animação de começo aqui, então chame uma função de começar o boss com Invoke com um timer chamando os codigos abaixo
        Invoke("StartBoss", 0.1f);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag=="Bullet" && started)
        {
            health -=1;
            Destroy(col.gameObject);
        }
    }

    void Update()
    {
        healthFill.fillAmount = health/healthTotal;

        if(healthFill.fillAmount<=0.66f && !isSecondPhase)
        {
            isSecondPhase = true;
            GetComponent<ChangePhase>().changeCD =  GetComponent<ChangePhase>().changeCDSecond;
        }else if(healthFill.fillAmount<=0.33f && !isThirdPhase)
        {
            isThirdPhase = true;
            GetComponent<ChangePhase>().changeCD =  GetComponent<ChangePhase>().changeCDThird;
        }
        if(healthFill.fillAmount<=0)
        {
            BossKilled();
        }
    }    

    void StartBoss()
    {
        started = true;
        isSecondPhase = false;
        isThirdPhase = false;
        StartCoroutine(GetComponent<ChangePhase>().ChangePhaseBehav());
        StartCoroutine(GetComponent<BlindScreen>().BlindScreenBehav());
        StartCoroutine(GetComponent<BlindOverflow>().BlindOverflowBehav());
        StartCoroutine(GetComponent<IGTeleport>().TeleportBehav());
    }
    void BossKilled()
    {
        SceneManager.LoadScene("Fim");
    }
}
