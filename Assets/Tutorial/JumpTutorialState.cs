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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tutorialUIManager.TransitionToNextState();
        }
    }

    public override void Exit()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

}
