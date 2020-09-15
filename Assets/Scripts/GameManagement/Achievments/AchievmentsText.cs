using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.SceneManagement;

public class AchievmentsText : MonoBehaviour
{
    EventSystem mEventSystem;
    [SerializeField] TMP_Text name;
    [SerializeField] Image icon;
    [SerializeField] TMP_Text desc;
    [SerializeField] GameObject achievPanel;
    [SerializeField] TMP_Text obt;
    void Start()
    {
        mEventSystem = EventSystem.current;
    }

    
    void Update()
    {
        name.text = mEventSystem.currentSelectedGameObject.GetComponent<AchievmentSlot>().achiev.name;
        icon.sprite = mEventSystem.currentSelectedGameObject.GetComponent<AchievmentSlot>().achiev.icon;
        desc.text = mEventSystem.currentSelectedGameObject.GetComponent<AchievmentSlot>().achiev.description;
        obt.text = GameObject.Find(mEventSystem.currentSelectedGameObject.name+"/Image").GetComponent<AchievmentsOpac>().obtido;
        if (Input.GetKeyDown (KeyCode.Escape))
        {
            if(achievPanel.activeInHierarchy)
            {
                HidePanel();
            }
            else
            {
                SceneManager.LoadScene("Menu");
            }
        }
    }

    public void ShowPanel()
    {
        achievPanel.SetActive(true);
    }

    public void HidePanel()
    {
        achievPanel.SetActive(false);
    }
}
