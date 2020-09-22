using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartOverflow : MonoBehaviour
{
    PlayerOverflow playerO;
    [SerializeField] int overNext;
    GameMaster gm;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        playerO = FindObjectOfType<PlayerOverflow>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerO.canOverflow = true;
            playerO.overLevel = overNext;
            Destroy(gameObject);
        }
    }
}
