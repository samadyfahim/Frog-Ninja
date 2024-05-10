using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftTutorialState : TutorialState
{
    public MoveLeftTutorialState(TutorialUIManager tutorialUIManager) : base(tutorialUIManager) { }

    public override void Enter()
    {
        DisplayInstructions("Use A to Move Left");
    }

    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            tutorialUIManager.TransitionToNextState();
        }
    }

 
}
