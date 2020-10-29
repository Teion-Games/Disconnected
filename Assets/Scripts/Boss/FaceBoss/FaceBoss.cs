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
    public float scrollPhaseDuration {get {return _scrollPhaseDuration;}}
    float health;
    bool started;
    bool canTakeDmg;
    bool _isScrolling;
    public bool isScrolling {get {return _isScrolling;} set  {_isScrolling = value;} }
    void Start()
    {
        StartCoroutine(RandomizeAction(randomizeActionTimer));
        canTakeDmg = true;
        started = true;
        health=healthTotal;
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
        if(healthFill.fillAmount<=0)
        {
            EndGame();
        }
    }

    private IEnumerator RandomizeAction(float randomActionTimer)
    {
        while (true)
        {
           yield return new WaitForSeconds(randomActionTimer);
           int actionDecided = Random.Range(1,2);
           switch (actionDecided)
           {
               case 1:
                    _isScrolling = true;
                    break;
           }
        }
    }

    void EndGame()
    {
        SceneManager.LoadScene("Fim");
    }
}
