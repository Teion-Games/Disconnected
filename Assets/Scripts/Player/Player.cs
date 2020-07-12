using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    int _currentController;
    Rigidbody2D _playerRB;
    private GameMaster gm;

    public Rigidbody2D playerRB { get { return _playerRB; } set { _playerRB = value; } }
    public int currentController { get { return _currentController; } set { _currentController = value; } }
    void Start()
    {
        AudioManager.instance.PlaySound("Main");
        _playerRB = GetComponent<Rigidbody2D>();
        _currentController = 1;
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        transform.position = gm._lastCheckPointPos;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            GameObject destroy = Instantiate(gm.particleDestroy, transform.position, Quaternion.identity);
            destroy.GetComponent<ParticleSystem>().Play();
            Destroy(GetComponent<SpriteRenderer>());
            Invoke("ResetScene", 0.3f);
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

    void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gm.CheckReset();
    }
}
