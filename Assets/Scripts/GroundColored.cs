using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundColored : MonoBehaviour
{
    public bool isEnabled;
    Collider2D col;
    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        col.enabled = isEnabled;
    }
}
