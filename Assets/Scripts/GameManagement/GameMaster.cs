using System.Collections;
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
		} else {
			Destroy(gameObject);
		}
	}
    #endregion
    private Vector3 lastCheckPointPos;
    public Vector3 _lastCheckPointPos { get{ return lastCheckPointPos;} set{lastCheckPointPos = value;}}
    private int _controllerLevel=0;
    public int controllerLevel {get {return _controllerLevel;} set  {_controllerLevel = value;} }
    public bool destroyThem = false;
    public bool isFirst = false;
    bool _showText=true;
    public bool showText {get {return _showText;} set  {_showText = value;} }
    GameObject[] butaos;

    void Update()
    {      
       if(destroyThem)
       {
           foreach (GameObject butao in GameObject.FindGameObjectsWithTag("BD"))
           {
               Destroy(butao);
           }
       } 
    }

    public void CheckReset()
    {
        if(isFirst && _controllerLevel==4)
        { 
            _controllerLevel--;
            isFirst=false;
        }
    }
}
