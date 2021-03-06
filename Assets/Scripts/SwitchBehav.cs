﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBehav : MonoBehaviour
{
    [SerializeField] EnemyPatrol[] enGround;
    [SerializeField] FlyEnemy[] enFly;
    [SerializeField] GroundColored[] colGround;
    bool canInteract = false;
    [SerializeField] GameObject interactCanvas;
    PlayerInput input;
    Color colorOn, colorOff, color2On, color2Off;
    GameMaster gm;
    public int wichColor;
    [SerializeField] Sprite spriteOff, spriteOn;


    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        input = FindObjectOfType<PlayerInput>();
        colorOn = gm.color1On;
        colorOff = gm.color1Off;
        color2On = gm.color2On;
        color2Off = gm.color2Off;
        Invoke("StartColors", 0.1f);
    }


    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            canInteract = true;
            interactCanvas.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            canInteract = false;
            interactCanvas.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

        enGround = gm.enGround;
        enFly = gm.enFly;
        colGround = gm.colGround;
        if (wichColor == 1)
        {
            
        }
        else if (wichColor == 2)
        {
            
        }

        if (canInteract && input.inputActions.PlayerControls.Interact.triggered)
        {
            AudioManager.instance.PlaySound("Activate");
            SwitchColors();
        }
    }

    void SwitchColors()
    {

        foreach (EnemyPatrol ground in enGround)
        {
            if (wichColor == 1)
            {
                if (ground.gameObject.layer == 9)
                {
                    ground.isEnabled = !ground.isEnabled;
                    if (ground.isEnabled)
                    {
                        ground.gameObject.GetComponent<SpriteRenderer>().color = colorOn;
                    }
                    else ground.gameObject.GetComponent<SpriteRenderer>().color = colorOff;
                }
                else
                {
                    ground.isEnabled = false;
                    ground.gameObject.GetComponent<SpriteRenderer>().color = color2Off;
                }
            }
            else if (wichColor == 2)
            {
                if (ground.gameObject.layer == 10)
                {
                    ground.isEnabled = !ground.isEnabled;
                    if (ground.isEnabled)
                    {
                        ground.gameObject.GetComponent<SpriteRenderer>().color = color2On;
                    }
                    else ground.gameObject.GetComponent<SpriteRenderer>().color = color2Off;
                }
                else
                {
                    ground.isEnabled = false;
                    ground.gameObject.GetComponent<SpriteRenderer>().color = colorOff;
                }
            }
        }

        foreach (FlyEnemy fly in enFly)
        {
            if (wichColor == 1)
            {
                if (fly.gameObject.layer == 9)
                {
                    fly.isEnabled = !fly.isEnabled;
                    if (fly.isEnabled)
                    {
                        fly.gameObject.GetComponent<SpriteRenderer>().color = colorOn;
                    }
                    else fly.gameObject.GetComponent<SpriteRenderer>().color = colorOff;
                }
                else
                {
                    fly.isEnabled = false;
                    fly.gameObject.GetComponent<SpriteRenderer>().color = color2Off;
                }
            }
            else if (wichColor == 2)
            {
                if (fly.gameObject.layer == 10)
                {
                    fly.isEnabled = !fly.isEnabled;
                    if (fly.isEnabled)
                    {
                        fly.gameObject.GetComponent<SpriteRenderer>().color = color2On;
                    }
                    else fly.gameObject.GetComponent<SpriteRenderer>().color = color2Off;
                }
                else
                {
                    fly.isEnabled = false;
                    fly.gameObject.GetComponent<SpriteRenderer>().color = colorOff;
                }
            }
        }
        foreach (GroundColored ground in colGround)
        {
            if (wichColor == 1)
            {
                if (ground.gameObject.layer == 9)
                {
                    ground.isEnabled = !ground.isEnabled;
                    if (ground.isEnabled)
                    {
                        ground.gameObject.GetComponent<SpriteRenderer>().color = colorOn;
                    }
                    else ground.gameObject.GetComponent<SpriteRenderer>().color = colorOff;
                }
                else if (ground.gameObject.layer == 11)
                {
                    ground.isEnabled = !ground.isEnabled;
                    if (ground.isEnabled)
                    {
                        ground.gameObject.GetComponent<SpriteRenderer>().color = colorOn;
                    }
                    else ground.gameObject.GetComponent<SpriteRenderer>().color = colorOff;
                }
                else if (ground.gameObject.layer == 10)
                {
                    ground.isEnabled = false;
                    ground.gameObject.GetComponent<SpriteRenderer>().color = color2Off;
                }
            }
            else if (wichColor == 2)
            {
                if (ground.gameObject.layer == 10)
                {
                    ground.isEnabled = !ground.isEnabled;
                    if (ground.isEnabled)
                    {
                        ground.gameObject.GetComponent<SpriteRenderer>().color = color2On;
                    }
                    else ground.gameObject.GetComponent<SpriteRenderer>().color = color2Off;
                }
                else if (ground.gameObject.layer == 12)
                {
                    ground.isEnabled = !ground.isEnabled;
                    if (ground.isEnabled)
                    {
                        ground.gameObject.GetComponent<SpriteRenderer>().color = color2On;
                    }
                    else ground.gameObject.GetComponent<SpriteRenderer>().color = color2Off;
                }
                else if (ground.gameObject.layer == 9)
                {
                    ground.isEnabled = false;
                    ground.gameObject.GetComponent<SpriteRenderer>().color = colorOff;
                }
            }
        }
    }

    void StartColors()
    {

        foreach (EnemyPatrol ground in enGround)
        {
            if (ground.gameObject.layer == 9 && ground.isEnabled)
            {
                ground.gameObject.GetComponent<SpriteRenderer>().color = colorOn;
            }
            else if (ground.gameObject.layer == 9 && !ground.isEnabled)
            {
                ground.gameObject.GetComponent<SpriteRenderer>().color = colorOff;
            }

            if (ground.gameObject.layer == 10 && ground.isEnabled)
            {
                ground.gameObject.GetComponent<SpriteRenderer>().color = color2On;
            }
            else if (ground.gameObject.layer == 10 && !ground.isEnabled)
            {
                ground.gameObject.GetComponent<SpriteRenderer>().color = color2Off;
            }
        }

        foreach (FlyEnemy fly in enFly)
        {
            if (fly.gameObject.layer == 9 && fly.isEnabled)
            {
                fly.gameObject.GetComponent<SpriteRenderer>().color = colorOn;
            }
            else if (fly.gameObject.layer == 9 && !fly.isEnabled)
            {
                fly.gameObject.GetComponent<SpriteRenderer>().color = colorOff;
            }

            if (fly.gameObject.layer == 10 && fly.isEnabled)
            {
                fly.gameObject.GetComponent<SpriteRenderer>().color = color2On;
            }
            else if (fly.gameObject.layer == 10 && !fly.isEnabled)
            {
                fly.gameObject.GetComponent<SpriteRenderer>().color = color2Off;
            }
        }

        foreach (GroundColored ground in colGround)
        {
            if (ground.gameObject.layer == 9 && ground.isEnabled)
            {
                ground.gameObject.GetComponent<SpriteRenderer>().color = colorOn;
            }
            else if (ground.gameObject.layer == 9 && !ground.isEnabled)
            {
                ground.gameObject.GetComponent<SpriteRenderer>().color = colorOff;
            }

            if (ground.gameObject.layer == 10 && ground.isEnabled)
            {
                ground.gameObject.GetComponent<SpriteRenderer>().color = color2On;
            }
            else if (ground.gameObject.layer == 10 && !ground.isEnabled)
            {
                ground.gameObject.GetComponent<SpriteRenderer>().color = color2Off;
            }

            if (ground.gameObject.layer == 11 && ground.isEnabled)
            {
                ground.gameObject.GetComponent<SpriteRenderer>().color = colorOn;
            }
            else if (ground.gameObject.layer == 11 && !ground.isEnabled)
            {
                ground.gameObject.GetComponent<SpriteRenderer>().color = colorOff;
            }

            if (ground.gameObject.layer == 12 && ground.isEnabled)
            {
                ground.gameObject.GetComponent<SpriteRenderer>().color = color2On;
            }
            else if (ground.gameObject.layer == 12 && !ground.isEnabled)
            {
                ground.gameObject.GetComponent<SpriteRenderer>().color = color2Off;
            }
        }
    }
}
