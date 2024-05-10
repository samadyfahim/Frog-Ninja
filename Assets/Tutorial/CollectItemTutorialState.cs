using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItemTutorialState : TutorialState
{
    private static bool itemCollected = false;
    public CollectItemTutorialState(TutorialUIManager tutorialUIManager) : base(tutorialUIManager) { }
    public override void Enter()
    {
        DisplayInstructions("Collect the Item");
    }
    public override void Update()
    {
        if (itemCollected)
        {
            tutorialUIManager.TransitionToNextState();
        }
    }
    public static void OnItemCollected()
    {
        itemCollected = true;
    }
}