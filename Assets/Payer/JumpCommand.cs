using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCommand : Command
{
    private Rigidbody2D rb;

    public JumpCommand(Rigidbody2D rb)
    {
        this.rb = rb;
    }

    public void Execute()
    {
        rb.velocity = new Vector2(0, 12);
    }
}
