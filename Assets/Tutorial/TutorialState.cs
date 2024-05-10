using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TutorialState
{

    protected TutorialUIManager tutorialUIManager;

    public TutorialState(TutorialUIManager tutorialUIManager)
    {
        this.tutorialUIManager = tutorialUIManager;
    }

    public abstract void Enter();
    public abstract void Update();

    protected void DisplayInstructions(string instructions)
    {
        tutorialUIManager.DisplayInstructions(instructions);
    }



}
