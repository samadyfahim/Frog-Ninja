using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private Text gameOverText;
    [SerializeField] private GameObject darkPanel;
    [SerializeField] private Button restartButton;
    [SerializeField] private Button homeButton;

    void Start()
    {
        restartButton.onClick.AddListener(RestartScene);
        homeButton.onClick.AddListener(OpenStartScene);
    }

    public void Die()
    {
        gameOverText.gameObject.SetActive(true);
        darkPanel.SetActive(true);
        restartButton.gameObject.SetActive(true);
        homeButton.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OpenStartScene()
    {
        SceneManager.LoadScene("Start", LoadSceneMode.Single);
    }
}
