using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialController : MonoBehaviour
{
    private TutorialState currentState;
    private TutorialUIManager tutorialUIManager;

    private void Start()
    {
        tutorialUIManager = GetComponent<TutorialUIManager>();
        if (tutorialUIManager == null)
        {
            Debug.LogError("TutorialUIManager component not found on the TutorialController's GameObject.");
            return;
        }

        StartTutorial();
    }

    private void StartTutorial()
    {
        currentState = new JumpTutorialState(tutorialUIManager);
        currentState.Enter();
    }

    public void TransitionToNextState()
    {
        switch (currentState)
        {
            case JumpTutorialState _:
                currentState = new MoveLeftTutorialState(tutorialUIManager);
                break;
            case MoveLeftTutorialState _:
                currentState = new MoveRightTutorialState(tutorialUIManager);
                break;
            case MoveRightTutorialState _:
                currentState = new AttackTutorialState(tutorialUIManager);
                break;
            case AttackTutorialState _:
                SceneManager.LoadScene("Level1");
                break;
        }

        currentState.Enter();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
