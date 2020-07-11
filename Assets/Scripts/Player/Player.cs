using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int _currentController;
    Rigidbody2D _playerRB;

    public Rigidbody2D playerRB {get {return _playerRB; }  set { _playerRB = value; } }
    public int currentController {get {return _currentController;} set  {_currentController = value;} }
    void Start()
    {
        _playerRB = GetComponent<Rigidbody2D>();
        _currentController = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
