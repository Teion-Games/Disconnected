using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerOverflow : MonoBehaviour
{
    bool _canOverflow;
    float overflowAmount = 0;
    PlayerInput input;
    public bool canOverflow { get { return _canOverflow; } set { _canOverflow = value; } }
    [SerializeField] Image overFill;
    [SerializeField] float vel;
    [SerializeField] float shotMult;
    Player playerScript;
    [SerializeField] int lastController = 3;
    int toChange = -1;

    void Start()
    {
        input = GetComponent<PlayerInput>();
        _canOverflow = true;
        playerScript = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_canOverflow)
        {
            overFill.fillAmount = overflowAmount;

            if (input.movH != 0 || input.jumpTrig || input.fallTrig)
            {
                overflowAmount += (Time.deltaTime * vel) / 100f;
            }
            if (overflowAmount >= 1)
            {
                AudioManager.instance.PlaySound("Overflow");
                overflowAmount = 0;
                playerScript.currentController = Randomize(playerScript.currentController);
            }
        }
        else overflowAmount = 0;
    }

    int Randomize(int notChange)
    {
        toChange = Random.Range(1, lastController);
        if (toChange != notChange)
        {
            return toChange;
        }
        else
        {
            return Randomize(notChange);
        }
    }

    public void ShotIncrement()
    {
        overflowAmount += (Time.deltaTime * vel * shotMult) / 100f;
    }
}
