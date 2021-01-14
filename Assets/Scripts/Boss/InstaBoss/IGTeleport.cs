using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IGTeleport : MonoBehaviour
{
    [SerializeField] Vector3[] positionsToTeleport;
    [SerializeField] float teleportCD;
    int currentPos;

    void Start()
    {
        currentPos = -1;
    }
    public IEnumerator TeleportBehav()
    {
        Debug.Log("teleport");
        while (true)
        {
            // anim.SetTrigger("teleport");
            // yield return new WaitForSeconds(0.2f);
            yield return new WaitForSeconds(teleportCD);
            for(;;)
            {
                int i = Random.Range(0, positionsToTeleport.Length);
                if (transform.position != positionsToTeleport[i])
                {
                    transform.position = positionsToTeleport[i];
                    break;
                }
            }
        }
    }
}
