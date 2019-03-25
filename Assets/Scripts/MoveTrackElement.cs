using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTrackElement : MonoBehaviour
{
    [SerializeField]
    float speed = 2.5f;
    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Vector3.left * speed * Time.deltaTime;
    }
}
