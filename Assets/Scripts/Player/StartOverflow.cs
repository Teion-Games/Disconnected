﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartOverflow : MonoBehaviour
{
    PlayerOverflow playerO;

    void Start()
    {
        playerO = FindObjectOfType<PlayerOverflow>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerO.canOverflow = true;
            Destroy(gameObject);
        }
    }
}
