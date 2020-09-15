using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievmentSlot : MonoBehaviour
{
    public Achievment achiev;

    void Start()
    {
        GameObject.Find(this.name+"/Image").GetComponent<Image>().sprite = achiev.icon;
    }
}
