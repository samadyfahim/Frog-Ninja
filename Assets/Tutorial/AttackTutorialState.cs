using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTutorialState : TutorialState
{
    public AttackTutorialState(TutorialUIManager tutorialUIManager) : base(tutorialUIManager) 
    { 

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public override void Enter()
    {
        DisplayInstructions("Click Mouse to Attack");
    }

    public override void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            tutorialUIManager.TransitionToNextState();
        }
    }
    public override void Exit()
    {

    }
}
