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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Die()
    {
        gameOverText.gameObject.SetActive(true);
        darkPanel.SetActive(true);
        restartButton.gameObject.SetActive(true);
        restartButton.onClick.AddListener(RestartScene);
        gameObject.SetActive(false);
        Debug.Log("die");
    }
    private void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
