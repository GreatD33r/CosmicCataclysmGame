using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StuffManager : MonoBehaviour
{
    public float LevelProgres;
    [SerializeField] private Slider ProgressBar;
    [SerializeField] GameObject pauseGameMenu;
    bool GamePaused = false;

    void Update()
    {

        ProgressBar.value = LevelProgres;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseGameMenu.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }

    public void Pause()
    {
        pauseGameMenu.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }
}
