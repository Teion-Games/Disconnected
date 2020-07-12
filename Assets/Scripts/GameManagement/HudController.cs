using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HudController : MonoBehaviour
{
    [SerializeField] GameObject moveText;
    [SerializeField] TMP_Text upText, downText, leftText, rightText;
    [SerializeField] GameObject[] rightFields, upFields, downFields, leftFields;

    Player playerScript;
    private GameMaster gm;

    void Start()
    {
        foreach (var item in collection)
        {
            
        }
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        playerScript = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (playerScript.currentController)
        {
            case 1:
            upText.text="↑";
            downText.text="↓";
            leftText.text="←";
            rightText.text="→";
                break;
            case 2:
            upText.text="W";
            downText.text="S";
            leftText.text="A";
            rightText.text="D";
                break;
        }
        switch (gm.controllerLevel)
        {
            case 0:
                rightFields[0].GetComponent<SpriteRenderer>().color = Color.green;
                rightFields[1].GetComponent<TextMeshProUGUI>().color = Color.green;
                rightFields[2].GetComponent<TextMeshProUGUI>().color = Color.green;
                upFields[0].GetComponent<SpriteRenderer>().color = Color.white;
                upFields[1].GetComponent<TextMeshProUGUI>().color = Color.white;
                upFields[2].GetComponent<TextMeshProUGUI>().color = Color.white;
                downFields[0].GetComponent<SpriteRenderer>().color = Color.white;
                downFields[1].GetComponent<TextMeshProUGUI>().color = Color.white;
                downFields[2].GetComponent<TextMeshProUGUI>().color = Color.white;
                leftFields[0].GetComponent<SpriteRenderer>().color = Color.white;
                leftFields[1].GetComponent<TextMeshProUGUI>().color = Color.white;
                leftFields[2].GetComponent<TextMeshProUGUI>().color = Color.white;
                break;
            case 1:
                upFields[0].GetComponent<SpriteRenderer>().color = Color.green;
                upFields[1].GetComponent<TextMeshProUGUI>().color = Color.green;
                upFields[2].GetComponent<TextMeshProUGUI>().color = Color.green;
                downFields[0].GetComponent<SpriteRenderer>().color = Color.white;
                downFields[1].GetComponent<TextMeshProUGUI>().color = Color.white;
                downFields[2].GetComponent<TextMeshProUGUI>().color = Color.white;
                leftFields[0].GetComponent<SpriteRenderer>().color = Color.white;
                leftFields[1].GetComponent<TextMeshProUGUI>().color = Color.white;
                leftFields[2].GetComponent<TextMeshProUGUI>().color = Color.white;
                break;
            case 2:
                downFields[0].GetComponent<SpriteRenderer>().color = Color.green;
                downFields[1].GetComponent<TextMeshProUGUI>().color = Color.green;
                downFields[2].GetComponent<TextMeshProUGUI>().color = Color.green;
                leftFields[0].GetComponent<SpriteRenderer>().color = Color.white;
                leftFields[1].GetComponent<TextMeshProUGUI>().color = Color.white;
                leftFields[2].GetComponent<TextMeshProUGUI>().color = Color.white;
                break;
            case 3:
                leftFields[0].GetComponent<SpriteRenderer>().color = Color.green;
                leftFields[1].GetComponent<TextMeshProUGUI>().color = Color.green;
                leftFields[2].GetComponent<TextMeshProUGUI>().color = Color.green;
                break;
        }
        moveText.SetActive(gm.showText);
    }
}
