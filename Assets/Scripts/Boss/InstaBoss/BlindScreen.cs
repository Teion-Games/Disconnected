using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlindScreen : MonoBehaviour
{
    [Tooltip("Duração do flash com fotos escondendo a tela")]
    [SerializeField] float blindScreenDuration;
    [Tooltip("tempo entre as ativações do flash com fotos escondendo a tela")]
    [SerializeField] float blindScreenCD;
    [Tooltip("HUD>BLindu")]
    [SerializeField] GameObject blindScreen;

    void Start()
    {
        
    }
    
    public IEnumerator BlindScreenBehav()
    {
        while (true)
        {
            Debug.Log("blindScreen");
            yield return new WaitForSeconds(blindScreenCD);
            blindScreen.SetActive(true);
            yield return new WaitForSeconds(blindScreenDuration);
            blindScreen.SetActive(false);
        }
    }
}
