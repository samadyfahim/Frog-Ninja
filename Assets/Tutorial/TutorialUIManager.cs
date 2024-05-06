using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialUIManager : MonoBehaviour
{
    public Text instructionsText;
    private TutorialController tutorialController;
    void Start()
    {
        tutorialController = FindObjectOfType<TutorialController>(); 
        
    }
    public void SetTutorialController(TutorialController controller)
    {
        tutorialController = controller;
       
    }


    public void DisplayInstructions(string instructions)
    {
        instructionsText.text = instructions;
    }

    public void TransitionToNextState()
    {
        
        if (tutorialController != null)
        {
            tutorialController.TransitionToNextState();
        }
       
    }

 
}
