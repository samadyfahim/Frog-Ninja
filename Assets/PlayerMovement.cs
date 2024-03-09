using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
    }


    private void Update()
    {
        PlayerJump();
        PlayerMoveLeftRight();
    }

    private void PlayerJump()
    {
        if (Input.GetButtonUp("Jump"))
        {
            rb.velocity = new Vector2(0, 12);
        }
    }
    private void PlayerMoveLeftRight()
    {
        float XDir = Input.GetAxis("Horizontal");
        float move = XDir * 10f;
        rb.velocity = new Vector2(move, rb.velocity.y);
    }

   
}
