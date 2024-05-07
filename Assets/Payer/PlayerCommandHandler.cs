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
    private Animator anim;
    private Rigidbody2D rb;
    private BoxCollider2D boxCollider;
    [SerializeField]private LayerMask groundLayerMask;

    private bool isGrounded = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        jumpCommand = new JumpCommand(rb);
        boxCollider = GetComponent<BoxCollider2D>();
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
            transform.localScale = new Vector3(-1, 1, 1);
            ExecuteCommand(moveLeftCommand);
        }
        else if (move > 0)
        {
            moveRightCommand = new MoveRightCommand(rb, move);
            transform.localScale = Vector3.one;
            ExecuteCommand(moveRightCommand);
        }
    }
    private void ExecuteCommand(Command command)
    {
        command.Execute();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            JumpCommand jumpCmd = jumpCommand as JumpCommand;
            if (jumpCmd != null)
            {
                jumpCmd.SetGrounded(true);
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
            JumpCommand jumpCmd = jumpCommand as JumpCommand;
            if (jumpCmd != null)
            {
                jumpCmd.SetGrounded(false);
            }
        }
    }

    /*
    private bool isGround()
    {
        RaycastHit2D raycastHit2D = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, 0);
        return raycastHit2D.collider;
    }

    */
}
