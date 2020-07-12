﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private GameMaster gm;
    public PlayerInputActions inputActions;
    Player playerScript;
    int controller;
    float _movH;
    bool _jumpTrig;
    bool _fallTrig;
    int controllerLevel=0;

    public float movH {get {return _movH;} set  {_movH = value;} }
    public bool jumpTrig {get {return _jumpTrig;} set  {_jumpTrig = value;} }
    public bool fallTrig {get {return _fallTrig;} set  {_fallTrig = value;} }

    void Start()
    {
        inputActions = new PlayerInputActions();
        inputActions.PlayerControls.Enable();
        playerScript = GetComponent<Player>();
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }


    void Update()
    {
        controllerLevel = gm.controllerLevel;
        controller = playerScript.currentController;
        if(inputActions.PlayerControls.Fire.triggered && controllerLevel > 3)
        { 
            GetComponent<GunBehav>().Fire();
        }
        if(inputActions.PlayerControls.Interact.triggered)
        {

        }
        switch (controller)
        {
            case 1: 
                if(inputActions.PlayerControls.Move1.ReadValue<float>()>0)
                {
                    _movH = 1;
                } 
                else if (inputActions.PlayerControls.Move1.ReadValue<float>()<0 && controllerLevel > 2) 
                {
                    _movH = -1;
                }
                else if (inputActions.PlayerControls.Move1.ReadValue<float>()==0)
                {
                    _movH = 0;
                }

                if(inputActions.PlayerControls.JumpFall1.ReadValue<float>()>0 && controllerLevel > 0)
                {
                    _jumpTrig = true;
                } 
                else if (inputActions.PlayerControls.JumpFall1.ReadValue<float>() < 0 && controllerLevel > 1)
                {
                    _fallTrig = true;
                    _jumpTrig = false;
                } else if (inputActions.PlayerControls.JumpFall1.ReadValue<float>() == 0)
                {
                    _fallTrig = false;
                    _jumpTrig = false;
                }
                break;
            case 2:
                if(inputActions.PlayerControls.Move2.ReadValue<float>()>0)
                {
                    _movH = 1;
                } 
                else if (inputActions.PlayerControls.Move2.ReadValue<float>()<0 && controllerLevel > 2) 
                {
                    _movH = -1;
                }
                else if (inputActions.PlayerControls.Move2.ReadValue<float>()==0)
                {
                    _movH = 0;
                }

                if(inputActions.PlayerControls.JumpFall2.ReadValue<float>()>0 && controllerLevel > 0)
                {
                    _jumpTrig = true;
                } 
                else if (inputActions.PlayerControls.JumpFall2.ReadValue<float>() < 0 && controllerLevel > 1)
                {
                    _fallTrig = true;
                    _jumpTrig = false;
                } else if (inputActions.PlayerControls.JumpFall2.ReadValue<float>() == 0)
                {
                    _fallTrig = false;
                    _jumpTrig = false;
                }
                break;
            case 3:
                if(inputActions.PlayerControls.Move3.ReadValue<float>()>0)
                {
                    _movH = 1;
                } 
                else if (inputActions.PlayerControls.Move3.ReadValue<float>()<0 && controllerLevel > 2) 
                {
                    _movH = -1;
                }
                else if (inputActions.PlayerControls.Move3.ReadValue<float>()==0)
                {
                    _movH = 0;
                }

                if(inputActions.PlayerControls.JumpFall3.ReadValue<float>()>0 && controllerLevel > 0)
                {
                    _jumpTrig = true;
                } 
                else if (inputActions.PlayerControls.JumpFall3.ReadValue<float>() < 0 && controllerLevel > 1)
                {
                    _fallTrig = true;
                    _jumpTrig = false;
                } else if (inputActions.PlayerControls.JumpFall3.ReadValue<float>() == 0)
                {
                    _fallTrig = false;
                    _jumpTrig = false;
                }
                break;
            case 4:
                if(inputActions.PlayerControls.Move4.ReadValue<float>()>0)
                {
                    _movH = 1;
                } 
                else if (inputActions.PlayerControls.Move4.ReadValue<float>()<0 && controllerLevel > 2) 
                {
                    _movH = -1;
                }
                else if (inputActions.PlayerControls.Move4.ReadValue<float>()==0)
                {
                    _movH = 0;
                }

                if(inputActions.PlayerControls.JumpFall4.ReadValue<float>()>0 && controllerLevel > 0)
                {
                    _jumpTrig = true;
                } 
                else if (inputActions.PlayerControls.JumpFall4.ReadValue<float>() < 0 && controllerLevel > 1)
                {
                    _fallTrig = true;
                    _jumpTrig = false;
                } else if (inputActions.PlayerControls.JumpFall4.ReadValue<float>() == 0)
                {
                    _fallTrig = false;
                    _jumpTrig = false;
                }
                break;
            case 5:
                if(inputActions.PlayerControls.Move5.ReadValue<float>()>0)
                {
                    _movH = 1;
                } 
                else if (inputActions.PlayerControls.Move5.ReadValue<float>()<0 && controllerLevel > 2) 
                {
                    _movH = -1;
                }
                else if (inputActions.PlayerControls.Move5.ReadValue<float>()==0)
                {
                    _movH = 0;
                }

                if(inputActions.PlayerControls.JumpFall5.ReadValue<float>()>0 && controllerLevel > 0)
                {
                    _jumpTrig = true;
                } 
                else if (inputActions.PlayerControls.JumpFall5.ReadValue<float>() < 0 && controllerLevel > 1)
                {
                    _fallTrig = true;
                    _jumpTrig = false;
                } else if (inputActions.PlayerControls.JumpFall5.ReadValue<float>() == 0)
                {
                    _fallTrig = false;
                    _jumpTrig = false;
                }
                break;
            case 6:
                if(inputActions.PlayerControls.Move6.ReadValue<float>()>0)
                {
                    _movH = 1;
                } 
                else if (inputActions.PlayerControls.Move6.ReadValue<float>()<0 && controllerLevel > 2) 
                {
                    _movH = -1;
                }
                else if (inputActions.PlayerControls.Move6.ReadValue<float>()==0)
                {
                    _movH = 0;
                }

                if(inputActions.PlayerControls.JumpFall6.ReadValue<float>()>0 && controllerLevel > 0)
                {
                    _jumpTrig = true;
                } 
                else if (inputActions.PlayerControls.JumpFall6.ReadValue<float>() < 0 && controllerLevel > 1)
                {
                    _fallTrig = true;
                    _jumpTrig = false;
                } else if (inputActions.PlayerControls.JumpFall6.ReadValue<float>() == 0)
                {
                    _fallTrig = false;
                    _jumpTrig = false;
                }
                break;
        }
    }
}
