using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhasesGenerator : MonoBehaviour
{
    [SerializeField] GameObject[] enemies;
    [SerializeField] Transform[] positions;
    
    void OnEnable()
    {
        int i = 0;
        foreach (GameObject enemy in enemies)
        {
            Instantiate(enemy, positions[i].position, Quaternion.identity);
            i++;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
