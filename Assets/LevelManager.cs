using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    int levelsUnlocked;

    public Button[] buttons;

    public void Start()
    {
        levelsUnlocked = PlayerPrefs.GetInt("levelsUnlocked" , 0);

        for (int i = 0; i < buttons.Length ; i++)
        {
            buttons[i].interactable = true;
        }

        for (int i = 0; i < levelsUnlocked ; i++)
        {
            buttons[i].interactable = false;
        }
    }

    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }

     public void LevelSelector()
    {
        SceneManager.LoadScene("Level Selector");
    }
}
