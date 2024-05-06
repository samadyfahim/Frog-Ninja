using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightTutorialState : TutorialState
{
    public MoveRightTutorialState(TutorialUIManager tutorialUIManager) : base(tutorialUIManager) { }

    public override void Enter()
    {
        DisplayInstructions("Use D to Move Right");
    }

    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            tutorialUIManager.TransitionToNextState();
        }
    }

    public override void Exit()
    {

    }


   
}
