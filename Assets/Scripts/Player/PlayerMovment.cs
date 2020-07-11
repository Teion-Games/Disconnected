using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    [Header("Variaveis de velocidade e pulo")]
    [SerializeField] float jumpVel=10;
    [SerializeField] float vel=10;
    [SerializeField] private float fallMultiplier=2.5f;
	[SerializeField] private float lowJumpMultiplier=2f;
    Player playerScript;
    PlayerInput input;
    [Header("Variaveis para pulo mais responsivo")]
	[Tooltip("Tempo que o jogo ira lembrar do player ter apertado para pular ate acertar o chao")]
	[Range(0.1f, 0.2f)]
	[SerializeField] private float jumpRememberTime;
	[Tooltip("Tempo que o jogo ira lembrar do isgrounded do player apos ele sair do chao para pular")]
	[Range(0f, 0.15f)]
	[SerializeField] private float groundedRememberTime;
	float jumpPressedRemember=0;
	float groundRemember=0;
    Transform tagGround;
    [SerializeField] private LayerMask playerMask;
    bool _isJumping, _isGround;
    
    void Start()
    {
        playerScript = GetComponent<Player>();
        input = GetComponent<PlayerInput>();
        tagGround = GameObject.Find(this.name+"/tagGround").transform;
    }

    
    void Update()
    {
        // diminui jumpPressedRemember com o tempo, mantendo <0 para o player não pular todo o tempo, mesma logica para o ground //
		jumpPressedRemember -= Time.deltaTime;
		groundRemember -= Time.deltaTime;
		//  Low vs High jump calculations //
		if (playerScript.playerRB.velocity.y < 0)
		{
			playerScript.playerRB.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
		} else if (playerScript.playerRB.velocity.y > 0 && !input.jumpTrig)
		{
			playerScript.playerRB.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
		}
        Move(input.movH);
        if(input.jumpTrig)
        {
            jumpPressedRemember = jumpRememberTime;
			// Invoke("ResetJumpCom", 0.05f);
        }
        if ((jumpPressedRemember > 0))
		{
			Jump();
		}
    }

    void FixedUpdate()
    {
        if (Physics2D.Linecast(transform.position, tagGround.position, playerMask))
		{
			groundRemember = groundedRememberTime;
			_isJumping = false;
			_isGround = true;
		} else _isGround = false;
    }
    void Move(float dir)
    {
        Vector2 moveVel = playerScript.playerRB.velocity;
        moveVel.x = dir * vel;
        playerScript.playerRB.velocity = moveVel;
    }

    void Jump()
    {
        if ((groundRemember > 0))
		{
			groundRemember = 0;
			jumpPressedRemember = 0;
			playerScript.playerRB.velocity = new Vector2(playerScript.playerRB.velocity.x, jumpVel);
		}
    }
}
