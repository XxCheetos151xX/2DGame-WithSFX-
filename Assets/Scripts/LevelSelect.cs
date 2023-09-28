using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    public Button[] Buttons;

    private void Awake()
    {
        int unlockedlevel = PlayerPrefs.GetInt("UnlockedLevel",1);
        for(int i =0; i<Buttons.Length; i++)
        {
            Buttons[i].interactable = false;
        }
        for(int i=0; i< unlockedlevel; i++)
        {
            Buttons[i].interactable = true;
        }
    }
    public void OpenLevel(int levelId)
    {
        string levelname = "Level" + levelId;
        SceneManager.LoadScene(levelname);
    }
}
