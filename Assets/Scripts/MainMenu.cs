﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private string gameScene;
    [SerializeField] private string creditScene;

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
}