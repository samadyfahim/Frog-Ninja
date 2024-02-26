using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    private void Update()
    {
        PlayerJump();
        PlayerGoLeft();
    }

    private void PlayerJump()
    {
        if (Input.GetButtonUp("Jump"))
        {
            rb.velocity = new Vector2(0, 12);
        }
    }
    private void PlayerGoLeft()
    {
        float XDir = Input.GetAxis("Horizontal");
        float forword = XDir * 10f;
        rb.velocity = new Vector2(forword, rb.velocity.y);
    }

   
}
