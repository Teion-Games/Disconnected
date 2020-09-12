using System.Collections;
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
        transform.position = gm._lastCheckPointPos;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy" && !isDed)
        {
            isDed = true;
            GameObject destroy = Instantiate(gm.particleDestroy, transform.position, Quaternion.identity);
            destroy.GetComponent<ParticleSystem>().Play();
            Destroy(GetComponent<SpriteRenderer>());
            Destroy(GetComponent<PlayerMovment>());
            Invoke("ResetScene", 1f);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ShowText")
        {
            gm.showText = false;
            Destroy(other.gameObject);
        }
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
