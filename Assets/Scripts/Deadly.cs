using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deadly : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<Runner>())
        {
            col.GetComponent<Runner>().Kill();
        }
    }
}
