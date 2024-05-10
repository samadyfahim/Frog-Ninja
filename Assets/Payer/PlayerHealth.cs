using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private Text gameOverText;
    [SerializeField] private GameObject darkPanel;
    [SerializeField] private Button restartButton;
    [SerializeField] private Button homeButton;

    // Start is called before the first frame update
    void Start()
    {
        homeButton.onClick.AddListener(OpenStartScene);

    }

    public void Die()
    {
        gameOverText.gameObject.SetActive(true);
        darkPanel.SetActive(true);
        restartButton.onClick.AddListener(RestartScene);
        restartButton.gameObject.SetActive(true);
        homeButton.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }
    private void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void OpenStartScene()
    {
        SceneManager.LoadScene("Start", LoadSceneMode.Single);
    }
}
