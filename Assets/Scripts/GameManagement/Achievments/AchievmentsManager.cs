using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class AchievmentsManager : MonoBehaviour
{
    #region Singleton
    public static AchievmentsManager instance;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    #endregion


    public void ManageAchievments()
    {
        
        // todos os controler fodase uaserhuasehru
        PlayerPrefs.SetInt("allControlers", 1);
        PlayerPrefs.SetInt("1oOverflow", 1);
        PlayerPrefs.SetInt("overflowKilled", 1);
        //first blood e highlander
        if(GameMaster.instance.deathCounter>=1)
        {
            PlayerPrefs.SetInt("firstBlood", 1);
        } else
        {
            PlayerPrefs.SetInt("highlander", 1);
        }

        //10 mortes e brilliant (e todos os abaixo)
        if(GameMaster.instance.deathCounter>=10)
        {
            PlayerPrefs.SetInt("10mortes", 1);
        }
        else
        {
            PlayerPrefs.SetInt("brilliant", 1);
            PlayerPrefs.SetInt("diamante", 1);
            PlayerPrefs.SetInt("platina", 1);
            PlayerPrefs.SetInt("ouro", 1);
            PlayerPrefs.SetInt("prata", 1);
            PlayerPrefs.SetInt("bronze", 1);
        }

        //50 mortes e diamante (e todos os abaixo)
        if(GameMaster.instance.deathCounter>=50)
        {
            PlayerPrefs.SetInt("50mortes", 1);
        }
        else
        {
            PlayerPrefs.SetInt("diamante", 1);
            PlayerPrefs.SetInt("platina", 1);
            PlayerPrefs.SetInt("ouro", 1);
            PlayerPrefs.SetInt("prata", 1);
            PlayerPrefs.SetInt("bronze", 1);
        }

        //100 mortes e platina (e todos os abaixo)
        if(GameMaster.instance.deathCounter>=100)
        {
            PlayerPrefs.SetInt("100mortes", 1);
        }
        else
        {
            PlayerPrefs.SetInt("platina", 1);
            PlayerPrefs.SetInt("ouro", 1);
            PlayerPrefs.SetInt("prata", 1);
            PlayerPrefs.SetInt("bronze", 1);
        }

        
        if(GameMaster.instance.deathCounter>=300)
        {
            PlayerPrefs.SetInt("300mortes", 1);
        }
        else
        {
            PlayerPrefs.SetInt("ouro", 1);
            PlayerPrefs.SetInt("prata", 1);
            PlayerPrefs.SetInt("bronze", 1);
        }

        if(GameMaster.instance.deathCounter>=500)
        {
            PlayerPrefs.SetInt("500mortes", 1);
        }
        else
        {
            PlayerPrefs.SetInt("prata", 1);
            PlayerPrefs.SetInt("bronze", 1);
        }

        if(GameMaster.instance.deathCounter>=1000)
        {
            PlayerPrefs.SetInt("1000mortes", 1);
        }
        else
        {
            PlayerPrefs.SetInt("bronze", 1);
        }

        // todos os achievments check
        if(PlayerPrefs.GetInt("highlander")==1 && PlayerPrefs.GetInt("firstBlood")==1 &&PlayerPrefs.GetInt("10mortes")==1 
        &&PlayerPrefs.GetInt("50mortes")==1 &&PlayerPrefs.GetInt("100mortes")==1 &&PlayerPrefs.GetInt("300mortes")==1 &&
        PlayerPrefs.GetInt("500mortes")==1 &&PlayerPrefs.GetInt("1000mortes")==1 &&PlayerPrefs.GetInt("1oOverflow")==1 &&
        PlayerPrefs.GetInt("overflowKilled")==1 &&PlayerPrefs.GetInt("allControlers")==1 &&PlayerPrefs.GetInt("bronze")==1 &&
        PlayerPrefs.GetInt("prata")==1 &&PlayerPrefs.GetInt("ouro")==1 &&PlayerPrefs.GetInt("platina")==1 &&
        PlayerPrefs.GetInt("diamante")==1 &&PlayerPrefs.GetInt("brilliant")==1 )
        {
            PlayerPrefs.SetInt("todosAchievments", 1);
        }
    }
}
