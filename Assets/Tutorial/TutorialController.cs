using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TutorialController : MonoBehaviour
{
    [SerializeField] private TutorialUIManager tutorialUIManager;
    [SerializeField] private PlayerMovement playerMovement;
    
    private TutorialState currentState;

    private void Start()
    {
        if (tutorialUIManager == null)
        {
            Debug.LogError("TutorialUIManager component not found on the TutorialController's GameObject.");
            return;
        }
        if (playerMovement == null)
        {
            Debug.LogError("PlayerMovement component not found in the scene.");
            return;
        }

        StartTutorial();
    }

    private void StartTutorial()
    {
        currentState = new JumpTutorialState(tutorialUIManager);
        currentState.Enter();
        //DisablePlayerMovement();
    }

    public void TransitionToNextState()
    {
        switch (currentState)
        {
            case JumpTutorialState _:
                Debug.Log("jump started");
                currentState = new MoveLeftTutorialState(tutorialUIManager);
                break;
            case MoveLeftTutorialState _:
                Debug.Log("left started");
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
       // EnablePlayerMovement();
    }
    private void DisablePlayerMovement()
    {
        if (playerMovement != null)
        {
            playerMovement.enabled = false;
        }
    }
    private void EnablePlayerMovement()
    {
        if (playerMovement != null)
        {
            playerMovement.enabled = true;
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
