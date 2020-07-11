using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    PlayerInputActions inputActions;
    Player playerScript;
    int controller;
    float _movH;
    bool _jumpTrig;

    public float movH {get {return _movH;} set  {_movH = value;} }
    public bool jumpTrig {get {return _jumpTrig;} set  {_jumpTrig = value;} }

    void Start()
    {
        inputActions = new PlayerInputActions();
        inputActions.PlayerControls.Enable();
        playerScript = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        controller = playerScript.currentController;
        switch (controller)
        {
            case 1: 
                if(inputActions.PlayerControls.Move1.ReadValue<float>()>0)
                {
                    _movH = 1;
                } 
                else if (inputActions.PlayerControls.Move1.ReadValue<float>()<0) 
                {
                    _movH = -1;
                }
                else if (inputActions.PlayerControls.Move1.ReadValue<float>()==0)
                {
                    _movH = 0;
                }

                if(inputActions.PlayerControls.JumpFall1.ReadValue<float>()>0)
                {
                    _jumpTrig = true;
                } 
                else if (inputActions.PlayerControls.JumpFall1.ReadValue<float>() <= 0)
                {
                    _jumpTrig = false;
                }
                break;
            case 2:
                Debug.Log("using second controller");
                break;
        }
    }
}
