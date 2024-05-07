using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftCommand : Command
{
    private Rigidbody2D rb;
    private float move;

    public MoveLeftCommand(Rigidbody2D rb, float move)
    {
        this.rb = rb;
        this.move = move;
    }

    public void Execute()
    {
        
        rb.velocity = new Vector2(move, rb.velocity.y);
    }
}
