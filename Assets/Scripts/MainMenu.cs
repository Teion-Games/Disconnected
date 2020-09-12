using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private string gameScene;
    [SerializeField] private string creditScene;
    GameMaster gm;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        AudioManager.instance.PlaySound("Menu");
    }

    public void Play()
    {
        SceneManager.LoadScene(gameScene);
    }

    public void Credits()
    {
        SceneManager.LoadScene(creditScene);
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
        Play();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(gameScene);
    }
}
