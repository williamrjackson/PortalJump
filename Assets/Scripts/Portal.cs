using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    private enum Level {Bottom, Middle, Top};
    [SerializeField]
    Level level = Level.Middle;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<Runner>())
        {
            col.transform.position = col.transform.position.With(y:YForLevel());
        }
    }

    float YForLevel()
    {
        switch (level)
        {
            case Level.Bottom:
                return -4.072f;
            case Level.Middle:
                return -0.675f;
            default:
                return 2.65f;
        }
    }
}
