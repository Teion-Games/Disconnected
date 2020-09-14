using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private string gameScene;
    GameMaster gm;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        AudioManager.instance.PlaySound("Menu");
    }

    public void LoadSceneFunc(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlayAgain()
    {
        gm._lastCheckPointPos = new Vector3(0f,0f,0f);
        gm.controllerLevel = 0;
        gm.deathCounter = 0;
        LoadSceneFunc("Tutorial");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(gameScene);
    }
}
