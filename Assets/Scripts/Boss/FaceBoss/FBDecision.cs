using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FBDecision : MonoBehaviour
{
    [SerializeField] float randomizeActionTimer;
    public bool started;


    void Start()
    {
        StartCoroutine(RandomizeAction());
        started = true;
    }


    private IEnumerator RandomizeAction()
    {
        while (true)
        {
           yield return new WaitForSeconds(randomizeActionTimer);
           int actionDecided = Random.Range(5,6);
           switch (actionDecided)
           {
               case 1:
                    GetComponent<FBScrollPhase>().MovePlataforms();
                    break;
                case 2:
                    GetComponent<FBInvulnerability>().FaceBossInvulnerability();
                    break;
                case 3:
                    GetComponent<FBSpawnHomingMissile>().HomingMissileSpawn();
                    break;
                case 5:
                    GetComponent<FBTurret>().BoostFireRate();
                    break;

           }
        }
    }

    public void BossKilled()
    {
        SceneManager.LoadScene("Fim");
    }
}
