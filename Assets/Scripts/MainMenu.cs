using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private string gameScene;
    [SerializeField] GameObject menuContinue, menuStart, continueButton, playButton;
    GameMaster gm;

    void Start()
    {
        if(PlayerPrefs.GetInt("Level")!=0||PlayerPrefs.GetFloat("PosX")!=0||PlayerPrefs.GetFloat("PosY")!=0)
        {
            menuContinue.SetActive(true);
            EventSystem.current.GetComponent<EventSystem>().SetSelectedGameObject(continueButton);
        }
        else
        {
            menuStart.SetActive(true);
            EventSystem.current.GetComponent<EventSystem>().SetSelectedGameObject(playButton);
        }
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        if(AudioManager.instance!=null)
        {
            AudioManager.instance.PlaySound("Menu");
        }
    }

    public void LoadSceneFunc(string sceneName)
    {
        // função para as outras cenas do menu
        SceneManager.LoadScene(sceneName);
    }

    public void Play()
    {
        // função para jogar/continue
        if(PlayerPrefs.GetInt("Level")==0)
        {
            if(PlayerPrefs.GetFloat("PosX")==0 && PlayerPrefs.GetFloat("PosY")==0)
            {
                // LoadSceneFunc("Cutscene1");
                 LoadSceneFunc("Tutorial");
            }
            else
            {
                LoadSceneFunc("Tutorial");
            }
        }
    }
    public void PlayAgain()
    {
        //função para new game/play again
        PlayerPrefs.SetFloat("PosX", 0);
        PlayerPrefs.SetFloat("PosY", 0);
        LoadSceneFunc("Tutorial");
    }
    
     public void QuitGame()
    {
        Application.Quit();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(gameScene);
    }
}
