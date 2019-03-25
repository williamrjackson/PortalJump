using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour
{
    [SerializeField]
    float jumpStrength = 10f;
    public Animator anim;
    Rigidbody2D rb;
    int jumpCount = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }
    void Jump()
    {
        if (jumpCount < 2)
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * jumpStrength);
            jumpCount++;
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        jumpCount = 0;
    }

    public void Kill()
    {
        transform.Scale(Vector3.zero, 1f);
    }
}
