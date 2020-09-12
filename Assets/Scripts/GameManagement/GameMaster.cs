﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    #region Singleton
    private static GameMaster instance;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    #endregion

    [SerializeField]
    private Vector3 lastCheckPointPos;
    int _deathCounter = 0;
    public int deathCounter { get { return _deathCounter; } set { _deathCounter = value; } }
    public Vector3 _lastCheckPointPos { get { return lastCheckPointPos; } set { lastCheckPointPos = value; } }
    private int _controllerLevel = 0;
    public int controllerLevel { get { return _controllerLevel; } set { _controllerLevel = value; } }
    public bool destroyThem = false;
    public bool isFirst = false;
    bool _showText = true;
    public bool showText { get { return _showText; } set { _showText = value; } }
    GameObject[] butaos;
    public Color color1On, color1Off, color2On, color2Off;
    public BouncingBall[] bolas;
    public EnemyGround[] enGround;
    public FlyEnemy[] enFly;
    public GroundColored[] colGround;
    public GameObject particleDestroy;
    public List<GameObject> dialogList = new List<GameObject>();
    void Start()
    {
        foreach (GameObject dialog in dialogList)
        {
            dialog.SetActive(true);
        }
    }
    void Update()
    {
        bolas = FindObjectsOfType<BouncingBall>();
        enGround = FindObjectsOfType<EnemyGround>();
        enFly = FindObjectsOfType<FlyEnemy>();
        colGround = FindObjectsOfType<GroundColored>();
        if (destroyThem)
        {
            foreach (GameObject butao in GameObject.FindGameObjectsWithTag("BD"))
            {
                Destroy(butao);
            }
        }
    }

    public void CheckReset()
    {
        if (isFirst && _controllerLevel == 4)
        {
            _controllerLevel--;
            isFirst = false;
        }
    }
}
