using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject gameMenuPanel;
    public GameObject levelPanel;
    public void ShowLevelPanel()
    {
        levelPanel.SetActive(true);
        gameMenuPanel.SetActive(false);
        Debug.Log("shwo called");
    }
    public void ShowGameMenu()
    {
        gameMenuPanel.SetActive(true);
        levelPanel.SetActive(false);
    }
}
