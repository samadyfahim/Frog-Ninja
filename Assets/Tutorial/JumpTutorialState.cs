using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTutorialState : TutorialState
{
    public JumpTutorialState(TutorialUIManager tutorialUIManager) : base(tutorialUIManager) { }

    public override void Enter()
    {
        DisplayInstructions("Press Space to Jump");
    }

    public override void Update()
    {
        Debug.Log(Input.GetButtonUp("Jump"));
        if (Input.GetButtonUp("Jump"))
        {
            Debug.Log("Transitioning to next state.");
            tutorialUIManager.TransitionToNextState();
        }
    }

    public override void Exit()
    {

    }
 }
