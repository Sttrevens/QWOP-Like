using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    public float speed = 10f;
    private Vector2 input;
    public Rigidbody2D[] rb2dlist;

    PlayerClimbing playerClimbing;

    // Update is called once per frame
    void Update()
    {
        input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (Input.GetKey(KeyCode.Q))
        {
            //if (playerClimbing.isClimbing == false)
            //{
            rb2dlist[0].velocity = input * speed;
            //}
        }

        else if (Input.GetKey(KeyCode.E))
        {
            //if (playerClimbing.isClimbing == false)
            //{
            rb2dlist[1].velocity = input * speed;
            //}
        }

        else if (Input.GetKey(KeyCode.Z))
        {
            //if (playerClimbing.isClimbing == false)
            //{
            rb2dlist[2].velocity = input * speed;
            //}
        }

        else if (Input.GetKey(KeyCode.C))
        {
            //if (playerClimbing.isClimbing == false)
            //{
            rb2dlist[3].velocity = input * speed;
            //}
        }
    }
}
