using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HudController : MonoBehaviour
{
    [SerializeField] GameObject moveText;
    [SerializeField] TMP_Text upText, downText, leftText, rightText;
    [SerializeField] GameObject[] rightFields, upFields, downFields, leftFields, spaceFields;
    [SerializeField] GameObject overflowObj;
    [SerializeField] TMP_Text deathCounterText;

    PlayerOverflow overflow;
    Player playerScript;
    private GameMaster gm;
    [SerializeField] private Color onColor, offColor;

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
        deathCounterText.text = "Mortes: " + gm.deathCounter.ToString();
        switch (playerScript.currentController)
        {
            case 1:
                upText.text = "↑";
                downText.text = "↓";
                leftText.text = "←";
                rightText.text = "→";
                break;
            case 2:
                upText.text = "W";
                downText.text = "S";
                leftText.text = "A";
                rightText.text = "D";
                break;
            case 3:
                upText.text = "T";
                downText.text = "G";
                leftText.text = "F";
                rightText.text = "H";
                break;
            case 4:
                upText.text = "I";
                downText.text = "K";
                leftText.text = "J";
                rightText.text = "L";
                break;
            case 5:
                upText.text = "S";
                downText.text = "X";
                leftText.text = "Z";
                rightText.text = "C";
                break;
            case 6:
                upText.text = "H";
                downText.text = "N";
                leftText.text = "B";
                rightText.text = "M";
                break;
        }
        switch (gm.controllerLevel)
        {
            case 0:
                rightFields[0].GetComponent<SpriteRenderer>().color = onColor;
                rightFields[1].GetComponent<TextMeshProUGUI>().color = onColor;
                rightFields[2].GetComponent<TextMeshProUGUI>().color = onColor;
                upFields[0].GetComponent<SpriteRenderer>().color = offColor;
                upFields[1].GetComponent<TextMeshProUGUI>().color = offColor;
                upFields[2].GetComponent<TextMeshProUGUI>().color = offColor;
                downFields[0].GetComponent<SpriteRenderer>().color = offColor;
                downFields[1].GetComponent<TextMeshProUGUI>().color = offColor;
                downFields[2].GetComponent<TextMeshProUGUI>().color = offColor;
                leftFields[0].GetComponent<SpriteRenderer>().color = offColor;
                leftFields[1].GetComponent<TextMeshProUGUI>().color = offColor;
                leftFields[2].GetComponent<TextMeshProUGUI>().color = offColor;
                spaceFields[0].GetComponent<SpriteRenderer>().color = offColor;
                spaceFields[1].GetComponent<TextMeshProUGUI>().color = offColor;
                break;
            case 1:
                upFields[0].GetComponent<SpriteRenderer>().color = onColor;
                upFields[1].GetComponent<TextMeshProUGUI>().color = onColor;
                upFields[2].GetComponent<TextMeshProUGUI>().color = onColor;
                downFields[0].GetComponent<SpriteRenderer>().color = offColor;
                downFields[1].GetComponent<TextMeshProUGUI>().color = offColor;
                downFields[2].GetComponent<TextMeshProUGUI>().color = offColor;
                leftFields[0].GetComponent<SpriteRenderer>().color = offColor;
                leftFields[1].GetComponent<TextMeshProUGUI>().color = offColor;
                leftFields[2].GetComponent<TextMeshProUGUI>().color = offColor;
                spaceFields[0].GetComponent<SpriteRenderer>().color = offColor;
                spaceFields[1].GetComponent<TextMeshProUGUI>().color = offColor;
                break;
            case 2:
                downFields[0].GetComponent<SpriteRenderer>().color = onColor;
                downFields[1].GetComponent<TextMeshProUGUI>().color = onColor;
                downFields[2].GetComponent<TextMeshProUGUI>().color = onColor;
                leftFields[0].GetComponent<SpriteRenderer>().color = offColor;
                leftFields[1].GetComponent<TextMeshProUGUI>().color = offColor;
                leftFields[2].GetComponent<TextMeshProUGUI>().color = offColor;
                spaceFields[0].GetComponent<SpriteRenderer>().color = offColor;
                spaceFields[1].GetComponent<TextMeshProUGUI>().color = offColor;
                break;
            case 3:
                leftFields[0].GetComponent<SpriteRenderer>().color = onColor;
                leftFields[1].GetComponent<TextMeshProUGUI>().color = onColor;
                leftFields[2].GetComponent<TextMeshProUGUI>().color = onColor;
                spaceFields[0].GetComponent<SpriteRenderer>().color = offColor;
                spaceFields[1].GetComponent<TextMeshProUGUI>().color = offColor;
                break;
            case 4:
                spaceFields[0].GetComponent<SpriteRenderer>().color = onColor;
                spaceFields[1].GetComponent<TextMeshProUGUI>().color = onColor;
                break;
        }
        moveText.SetActive(gm.showText);
    }
}
