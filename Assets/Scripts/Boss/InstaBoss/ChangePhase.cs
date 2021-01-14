using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePhase : MonoBehaviour
{
    [Tooltip("Crie um game object e dentro dele coloque tudo que está dentro de uma fase, adcione esse GO aqui, repita para todas as fases")]
    [SerializeField] GameObject[] phasesOption;
    public float changeCD, changeCDSecond, changeCDThird;
    int curPhase;
    Transform playerTrans;

    void Start()
    {
        playerTrans = FindObjectOfType<Player>().GetComponent<Transform>();
        curPhase = -1;
    }

    public IEnumerator ChangePhaseBehav()
    {
        while(true)
        {
            Debug.Log("changephase");
            yield return new WaitForSeconds(changeCD);
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
}
