using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator anim;
    PlayerInput input;
    private GameMaster gm;
    Rigidbody2D rb;
    GunBehav gun;
    PlayerMovment playermov;
    DialogManager dialog;
    void Start()
    {
        dialog = FindObjectOfType<DialogManager>();
        playermov = GetComponent<PlayerMovment>();
        gun = GetComponent<GunBehav>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        input = GetComponent<PlayerInput>();
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }

    
    void Update()
    {
        if(input.movH!=0 && !dialog.isDialog)
        {
            anim.SetBool("Moving", true);
        } else anim.SetBool("Moving", false);

        if(rb.velocity.y>0.05)
        {
            anim.SetBool("Jumping", true);
            anim.SetBool("Falling", false);
        } else if(rb.velocity.y<-0.05)
        {
            anim.SetBool("Jumping", false);
            anim.SetBool("Falling", true);
        } else if (playermov.isGround || rb.velocity.y==0)
        {
            anim.SetBool("Falling", false);
        }

        if(input.inputActions.PlayerControls.Fire.triggered && gm.controllerLevel>3 && gun.shooting)
        {
            anim.SetBool("Shooting",true);
        } else anim.SetBool("Shooting",false);
    }
}
