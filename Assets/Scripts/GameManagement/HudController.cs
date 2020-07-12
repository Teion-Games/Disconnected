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
    [SerializeField] GameObject overflowObj;

    PlayerOverflow overflow;
    Player playerScript;
    private GameMaster gm;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        playerScript = FindObjectOfType<Player>();
        overflow = FindObjectOfType<PlayerOverflow>();
    }

    // Update is called once per frame
    void Update()
    {
        overflowObj.SetActive(overflow.canOverflow);
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
            case 3:
            upText.text="T";
            downText.text="G";
            leftText.text="F";
            rightText.text="H";
                break;
            case 4:
            upText.text="I";
            downText.text="K";
            leftText.text="J";
            rightText.text="L";
                break;
            case 5:
            upText.text="S";
            downText.text="X";
            leftText.text="Z";
            rightText.text="C";
                break;
            case 6:
            upText.text="H";
            downText.text="N";
            leftText.text="B";
            rightText.text="M";
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
