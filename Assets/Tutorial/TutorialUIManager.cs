using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialUIManager : MonoBehaviour
{
    public Text instructionsText;
    private TutorialController tutorialController;

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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
