using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialController : MonoBehaviour
{
    [SerializeField] private TutorialUIManager tutorialUIManager;
    [SerializeField] private PlayerCommandHandler playerCommandHandler;
    private TutorialState currentState;
    private void Start() 
    {
        StartTutorial();
    }
    private void StartTutorial() 
    {
        currentState = new JumpTutorialState(tutorialUIManager);
        currentState.Enter();
        DisablePlayerMovement();
    }
    public void TransitionToNextState() 
    {
        switch (currentState) {
            case JumpTutorialState:
                currentState = new MoveLeftTutorialState(tutorialUIManager);
                break;
            case MoveLeftTutorialState:
                currentState = new MoveRightTutorialState(tutorialUIManager);
                break;
            case MoveRightTutorialState:
                currentState = new CollectItemTutorialState(tutorialUIManager);
                break;
            case CollectItemTutorialState:
                LevelController.Instance.UnlockLevel(1);
                LevelController.Instance.LoadNextLevel();
                break;
        }
        currentState.Enter();
       EnablePlayerMovement();
    }
    private void DisablePlayerMovement() 
    {
        if (playerCommandHandler != null) 
        {
            playerCommandHandler.enabled = false;
        }
    }
    private void EnablePlayerMovement() 
    {
        if (playerCommandHandler != null) 
        {
            playerCommandHandler.enabled = true;
        }
    }

    void Update() 
    {
        if (currentState != null) 
        {
            currentState.Update();
        }
    }

}
