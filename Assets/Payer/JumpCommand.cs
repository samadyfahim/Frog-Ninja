using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCommand : Command
{
    private Rigidbody2D rb;
    private int maxJumps = 2;
    private int jumpsPerformed = 0;

    public JumpCommand(Rigidbody2D rb)
    {
        this.rb = rb;
    }

    public void Execute()
    {
        if (jumpsPerformed < maxJumps)
        {
            rb.velocity = new Vector2(0, 8);
            jumpsPerformed++;
        }
    }
    public void ResetJumpCount()
    {
        jumpsPerformed = 0;
    }
}
