﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    int _currentController;
    Rigidbody2D _playerRB;
    private GameMaster gm;
    bool isDed;

    public Rigidbody2D playerRB { get { return _playerRB; } set { _playerRB = value; } }
    public int currentController { get { return _currentController; } set { _currentController = value; } }
    
    void Start()
    {
        isDed = false;
        Invoke("StartAudio", 0.1f);
        _playerRB = GetComponent<Rigidbody2D>();
        _currentController = 1;
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        //duas linhas para xitar o checkpoint system enquanto teste
        PlayerPrefs.SetFloat("PosX", -17.5f);
        PlayerPrefs.SetFloat("PosY", 2.9f);
        transform.position = new Vector3(PlayerPrefs.GetFloat("PosX"), PlayerPrefs.GetFloat("PosY"), 0f);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy" && !isDed)
        {
            Die();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Enemy" && !isDed)
        {
            Die();
        }

        if (other.gameObject.tag == "ShowText")
        {
            gm.showText = false;
            Destroy(other.gameObject);
        }
    }

    void Die()
    {
        isDed = true;
        GameObject destroy = Instantiate(gm.particleDestroy, new Vector3(transform.position.x, transform.position.y+1f, transform.position.z), Quaternion.identity);
        destroy.GetComponent<ParticleSystem>().Play();
        Destroy(GetComponent<SpriteRenderer>());
        Destroy(GetComponent<PlayerMovment>());
        _playerRB.isKinematic=true;
        gameObject.GetComponent<Collider2D>().isTrigger=true;
        _playerRB.velocity = new Vector3(0f,0f,0f);
        Invoke("ResetScene", 1f);
    }

    void StartAudio()
    {
        AudioManager.instance.PlaySound("Main");
    }
    void ResetScene()
    {
        gm.deathCounter += 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gm.CheckReset();
    }
}
