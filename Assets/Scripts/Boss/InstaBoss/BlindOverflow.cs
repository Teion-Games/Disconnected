using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlindOverflow : MonoBehaviour
{
    [Tooltip("duração de esconder a barra de overflow")]
    [SerializeField] float overflowHideDuration;
    [Tooltip("tempo entre as ativações de esconder a barra de overflow")]
    [SerializeField] float overflowHideCD;
    [Tooltip("HUD>OverflowBreak")]
    [SerializeField] GameObject overflowBlind;

    void Start()
    {
        
    }
    
    public IEnumerator BlindOverflowBehav()
    {
        while (true)
        {
            Debug.Log("blindOF");
            yield return new WaitForSeconds(overflowHideCD);
            overflowBlind.SetActive(true);
            yield return new WaitForSeconds(overflowHideDuration);
            overflowBlind.SetActive(false);
        }
    }
}
