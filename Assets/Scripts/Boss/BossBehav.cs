using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossBehav : MonoBehaviour
{
    [SerializeField] Vector3[] positionsToTeleport;
    [Tooltip("O primeiro é o tempo entre um blind e outro, o segundo é a duracao do blind")]
    [SerializeField] float blindCD, blindDuration;
    [Tooltip("tempo de CD da onda de tiros")]
    [SerializeField] float shootTime;
    [SerializeField] float shootTimeSecondPhase;
    [SerializeField] float shootTimeThirdPhase;
    [Tooltip("tempo de CD do teleporte")]
    [SerializeField] float teleportTime;
    [SerializeField] float teleportTimeSecondPhase;
    [SerializeField] float teleportTimeThirdPhase;
    [Tooltip("Total de tiros necessários para matar o boss")]
    [SerializeField] float healthTotal;
    [SerializeField] Image healthFill;
    [SerializeField] GameObject bullet;
    [SerializeField] float bulletSpeed;
    [SerializeField] GameObject blindScreen;
    Transform gunPoint;
    float health;
    bool isSecondPhase=false;
    bool isThirdPhase = false;
    GameObject playerGO;
    bool firstPhaseStarted = false;
    bool secondPhaseStarted = false;
    bool thirdPhaseStarted = false;

    void Start()
    {
        playerGO = FindObjectOfType<Player>().gameObject;
        gunPoint =  GameObject.Find(this.name+"/gunPoint").transform;
        health=healthTotal;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag=="Bullet")
        {
            health -=1;
            Destroy(col.gameObject);
        }
    }
    void Update()
    {
        healthFill.fillAmount = health/healthTotal;
        gunPoint.LookAt(new Vector3(playerGO.transform.position.x, playerGO.transform.position.y+2f, playerGO.transform.position.z));

        if(!isThirdPhase)
        {
            if(isSecondPhase)
            {
                //second phase behav
                if(!secondPhaseStarted)
                {
                    StopAllCoroutines();
                    StartCoroutine(ShootingBehav(shootTimeSecondPhase));
                    StartCoroutine(TeleportBehav(teleportTimeSecondPhase));
                    FindObjectOfType<PlayerOverflow>().overBreak = true;
                    secondPhaseStarted = true;
                }
            }
            else
            {
                //first phase behav
                if(!firstPhaseStarted)
                {
                    StartCoroutine(ShootingBehav(shootTime));
                    StartCoroutine(TeleportBehav(teleportTime));
                    firstPhaseStarted = true;
                }
            }
        }
        else
        {
            //third phase behav
             if(!thirdPhaseStarted)
                {
                    StopAllCoroutines();
                    StartCoroutine(ShootingBehav(shootTimeThirdPhase));
                    StartCoroutine(TeleportBehav(teleportTimeThirdPhase));
                    StartCoroutine(BlindTheScreen(blindCD, blindDuration));
                    FindObjectOfType<PlayerOverflow>().overBreak = true;
                    thirdPhaseStarted = true;
                }
        }

        //phases changer
        if(healthFill.fillAmount<=0.66f && !isSecondPhase)
        {
            isSecondPhase = true;
        }else if(healthFill.fillAmount<=0.33f && !isThirdPhase)
        {
            isThirdPhase = true;
        }

        //dies
        if(healthFill.fillAmount<=0)
        {
            EndGame();
        }
    }

    
    private IEnumerator ShootingBehav(float shotTime)
    {
        while (true)
        {
            for(int i=0;i<5;i++)
            {
                yield return new WaitForSeconds(0.5f);
                GameObject bulleto = Instantiate(bullet, gunPoint.position, Quaternion.identity);
                bulleto.GetComponent<Rigidbody2D>().velocity = gunPoint.forward * bulletSpeed;
            }
            yield return new WaitForSeconds(shotTime);
        }
    }

     private IEnumerator TeleportBehav(float teleportTime)
    {
        while (true)
        {
            for(;;)
            {
                int i = Random.Range(0, positionsToTeleport.Length);
                if (transform.position != positionsToTeleport[i])
                {
                    transform.position = positionsToTeleport[i];
                    break;
                }
            }
            yield return new WaitForSeconds(teleportTime);
        }
    }


    private IEnumerator BlindTheScreen(float blindCD, float blindDuration)
    {
        while (true)
        {
            yield return new WaitForSeconds(blindCD);
            blindScreen.SetActive(true);
            yield return new WaitForSeconds(blindDuration);
            blindScreen.SetActive(false);
        }
    }
    void EndGame()
    {
        AchievmentsManager.instance.ManageAchievments();
        SceneManager.LoadScene("Fim");
    }
}
