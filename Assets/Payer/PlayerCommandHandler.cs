using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Input;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerCommandHandler : MonoBehaviour

{
    private Command jumpCommand;
    private Command moveLeftCommand;
    private Command moveRightCommand;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpCommand = new JumpCommand(rb);
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
            ExecuteCommand(jumpCommand);
           
        }
    }
    private void PlayerMoveLeftRight()
    {
        float XDir = Input.GetAxis("Horizontal");
        float move = XDir * 10f;

        if (move < 0)
        {
            moveLeftCommand = new MoveLeftCommand(rb, move);
            ExecuteCommand(moveLeftCommand);
        }
        else if (move > 0)
        {
            moveRightCommand = new MoveRightCommand(rb, move);
            ExecuteCommand(moveRightCommand);
        }
    }
    private void ExecuteCommand(Command command)
    {
        command.Execute();
    }


}
