using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelButton : MonoBehaviour
{
    private int levelNumber;
    private Button button;

    void OnEnable()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(() => LevelController.Instance.LoadLevel(levelNumber));

        button.interactable = LevelController.Instance.IsLevelUnlocked(levelNumber);
    }
}

