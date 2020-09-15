using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievmentsOpac : MonoBehaviour
{
    [SerializeField] string achievPrefs;
    Image image;
    public string obtido = "";

    void Start()
    {
        image = GetComponent<Image>();
        int tempor = PlayerPrefs.GetInt(achievPrefs);
        if(tempor==1)
        {
            var tempColor = image.color;
            tempColor.a = 1f;
            image.color = tempColor;
            obtido = "Já Obtido";
        }
        else
        {
            var tempColor = image.color;
            tempColor.a = 0.5f;
            image.color = tempColor;
            obtido = "Não Obtido";
        }
    }

}
