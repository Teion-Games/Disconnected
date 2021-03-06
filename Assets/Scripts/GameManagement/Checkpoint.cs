﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

	private GameMaster gm;
	[SerializeField] bool isDestroy=false;
	[SerializeField] bool isFirst = false;

	void Start()
	{
		gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			PlayerPrefs.SetFloat("PosX", transform.position.x);
			PlayerPrefs.SetFloat("PosY", transform.position.y);
			gm.destroyThem = isDestroy;  
			gm.isFirst = isFirst;
			Destroy(gameObject);
		}
	}
}
