using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InstaBoss : MonoBehaviour
{
    [Tooltip("Crie um game object e dentro dele coloque tudo que está dentro de uma fase, adcione esse GO aqui, repita para todas as fases")]
    [SerializeField] GameObject[] phasesOption;
    [SerializeField] Vector3[] positionsToTeleport;
    [Tooltip("Duração do flash com fotos escondendo a tela")]
    [SerializeField] float blindScreenDuration;
    [Tooltip("tempo entre as ativações do flash com fotos escondendo a tela")]
    [SerializeField] float blindScreenCD;
    [Tooltip("duração de esconder a barra de overflow")]
    [SerializeField] float overflowHideDuration;
    [Tooltip("tempo entre as ativações de esconder a barra de overflow")]
    [SerializeField] float overflowHideCD;
    [SerializeField] float healthTotal;
    [Tooltip("HUD>BossHP>Border>hpFill")]
    [SerializeField] Image healthFill;
    [Tooltip("HUD>BLindu")]
    [SerializeField] GameObject blindScreen;
    [Tooltip("HUD>OverflowBreak")]
    [SerializeField] GameObject overflowBlind;
    [SerializeField] float teleportCD;
    float health;
    [SerializeField] float changeCDFirst, changeCDSecond, changeCDThird;
    int curPhase;
    bool isSecondPhase, isThirdPhase;
    bool started = false;
    Coroutine ChangePhaseCorr;
    Transform playerTrans;
    void Start()
    {
        health=healthTotal;
        playerTrans = FindObjectOfType<Player>().GetComponent<Transform>();
        //toque a animação de começo aqui, então chame uma função de começar o boss com Invoke com um timer chamando os codigos abaixo
        started = true;
        curPhase = -1;
        isSecondPhase = false;
        isThirdPhase = false;
        ChangePhaseCorr = StartCoroutine(ChangePhase(changeCDFirst));
        StartCoroutine(BlindScreen(blindScreenCD, blindScreenDuration));
        StartCoroutine(BlindOverFlow(overflowHideCD, overflowHideDuration));
        StartCoroutine(TeleportBehav(teleportCD));
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
            StopCoroutine(ChangePhaseCorr);
            ChangePhaseCorr = StartCoroutine(ChangePhase(changeCDSecond));
        }else if(healthFill.fillAmount<=0.33f && !isThirdPhase)
        {
            isThirdPhase = true;
            StopCoroutine(ChangePhaseCorr);
            StartCoroutine(ChangePhase(changeCDThird));
        }
        if(healthFill.fillAmount<=0)
        {
            EndGame();
        }
    }

    private IEnumerator ChangePhase(float changeCD)
    {
        while(true)
        {

            int newPhase = Randomize(curPhase);
            if(curPhase != -1) phasesOption[curPhase].SetActive(false);
            foreach (GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy"))
            {
                if(enemy != this.gameObject)
                {
                    enemy.SetActive(false);
                }
            }
            phasesOption[newPhase].SetActive(true);
            curPhase = newPhase;
            playerTrans.position = new Vector3(PlayerPrefs.GetFloat("PosX"), PlayerPrefs.GetFloat("PosY"), 0f);
            yield return new WaitForSeconds(changeCD);
        }
    }

    private IEnumerator BlindScreen(float blindScreenCD, float blindScreenDuration)
    {
        while (true)
        {
            yield return new WaitForSeconds(blindScreenCD);
            blindScreen.SetActive(true);
            yield return new WaitForSeconds(blindScreenDuration);
            blindScreen.SetActive(false);
        }
    }

    private IEnumerator BlindOverFlow(float overflowHideCD, float overflowHideDuration)
    {
        while (true)
        {
            yield return new WaitForSeconds(overflowHideCD);
            overflowBlind.SetActive(true);
            yield return new WaitForSeconds(overflowHideDuration);
            overflowBlind.SetActive(false);
        }
    }

     private IEnumerator TeleportBehav(float teleportTime)
    {
        while (true)
        {
            // anim.SetTrigger("teleport");
            // yield return new WaitForSeconds(0.2f);
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

    int Randomize(int notChange)
    {
        int toChange = Random.Range(0, phasesOption.Length);
        if (toChange != notChange)
        {
            return toChange;
        }
        else
        {
            return Randomize(notChange);
        }
    }

    void EndGame()
    {
        SceneManager.LoadScene("Fim");
    }
}
