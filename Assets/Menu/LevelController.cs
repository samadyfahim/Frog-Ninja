using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class LevelController : MonoBehaviour
{
    public static LevelController Instance;


    public int unlockedLevel = 0;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            LoadProgress();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void UnlockLevel(int levelNumber)
    {
        if (levelNumber > unlockedLevel)
        {
            unlockedLevel = levelNumber;
            SaveProgress();
        }
    }
    private void SaveProgress()
    {
        PlayerPrefs.SetInt("HighestUnlockedLevel", unlockedLevel);
        PlayerPrefs.Save();
    }
    public bool IsLevelUnlocked(int levelNumber)
    {
        return levelNumber <= unlockedLevel;
    }

    private void LoadProgress()
    {
        unlockedLevel = PlayerPrefs.GetInt("HighestUnlockedLevel", 0);
    }
    public void LoadNextLevel()
    {
        int currentLevelIndex = SceneManager.GetActiveScene().buildIndex;
        int nextLevelIndex = currentLevelIndex + 1;

        if (nextLevelIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextLevelIndex);
        }
    }
    public void LoadLevel(int levelNumber)
    {
        if (IsLevelUnlocked(levelNumber))
        {
            SceneManager.LoadScene("Level" + levelNumber);
        }
    }

    public void ResetProgress()
    {
        PlayerPrefs.SetInt("HighestUnlockedLevel", 0);
        PlayerPrefs.Save();
    }
    public void QuitGame()
    {
        Application.Quit();
    }


}
