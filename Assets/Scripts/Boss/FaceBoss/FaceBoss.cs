using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FaceBoss : MonoBehaviour
{
    [SerializeField] float healthTotal;
    [Tooltip("HUD>BossHP>Border>hpFill")]
    [SerializeField] Image healthFill;
    [SerializeField] float randomizeActionTimer;
    [SerializeField] float _scrollPhaseDuration;
    [SerializeField] float invencivelDuration;
    [SerializeField] GameObject homingMissilePrefab;
    public float scrollPhaseDuration {get {return _scrollPhaseDuration;}}
    float health;
    float saveinvencivelDuration;
    bool started;
    bool canTakeDmg;
    bool _isScrolling;
    public bool isScrolling {get {return _isScrolling;} set  {_isScrolling = value;} }
    void Start()
    {
        StartCoroutine(RandomizeAction());
        canTakeDmg = true;
        started = true;
        health=healthTotal;
        saveinvencivelDuration = invencivelDuration;
    }

     void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag=="Bullet" && started && canTakeDmg)
        {
            health -=1;
            Destroy(col.gameObject);
        }
    }
    void Update()
    {
        healthFill.fillAmount = health/healthTotal;
        //em cada fase alterar o cd de cada uma das coisas
        if(healthFill.fillAmount<=0)
        {
            EndGame();
        }

        if(!canTakeDmg)
        {
            ResetCanTakeDmg();
        }
    }

    private IEnumerator RandomizeAction()
    {
        while (true)
        {
           yield return new WaitForSeconds(randomizeActionTimer);
           int actionDecided = Random.Range(2,3);
           switch (actionDecided)
           {
               case 1:
                    _isScrolling = true;
                    break;
                case 2:
                    canTakeDmg = false;
                    break;
                case 3:
                    HomingMissileSpawn();
                    break;
           }
        }
    }

    void ResetCanTakeDmg()
    {
        if(invencivelDuration<=0)
        {
            canTakeDmg = true;
            invencivelDuration = saveinvencivelDuration;
        } 
        else
        {
            invencivelDuration -= Time.deltaTime;    
        }
    }

    void HomingMissileSpawn()
    {
        Instantiate(homingMissilePrefab, transform.position, Quaternion.identity);
    }

    void EndGame()
    {
        SceneManager.LoadScene("Fim");
    }
}
