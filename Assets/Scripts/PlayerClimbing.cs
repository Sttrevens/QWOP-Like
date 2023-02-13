using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClimbing : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public bool isClimbing = false;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Climbable")
        {
            isClimbing = true;
            rb2d.velocity = Vector2.zero;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Climbable")
        {
            isClimbing = false;
        }
    }
}