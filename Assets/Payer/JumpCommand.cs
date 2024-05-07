using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCommand : Command
{
    private Rigidbody2D rb;
    private int maxJumps = 2;
    private int jumpsPerformed = 0;
    private bool isGrounded = false;

    public JumpCommand(Rigidbody2D rb)
    {
        this.rb = rb;
    }

    public void Execute()
    {
        if (isGrounded || jumpsPerformed < maxJumps)
        {
            rb.velocity = new Vector2(0, 8);
            jumpsPerformed++;
        }
    }
    
    public void SetGrounded(bool grounded)
    {

        isGrounded = grounded;
        if (grounded)
        {
            jumpsPerformed = 0;
        }
    }
}
