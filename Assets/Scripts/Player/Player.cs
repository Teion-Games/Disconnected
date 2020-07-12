using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    int _currentController;
    Rigidbody2D _playerRB;
    private GameMaster gm;

    public Rigidbody2D playerRB {get {return _playerRB; }  set { _playerRB = value; } }
    public int currentController {get {return _currentController;} set  {_currentController = value;} }
    void Start()
    {
        _playerRB = GetComponent<Rigidbody2D>();
        _currentController = 2;
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
		transform.position = gm._lastCheckPointPos;
    }

    void OnCollisionEnter2D (Collision2D other)
    {
        if(other.gameObject.tag=="Enemy")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            gm.CheckReset();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="ShowText")
        {
            gm.showText = false;
            Destroy(other.gameObject);
        }
    }
}
