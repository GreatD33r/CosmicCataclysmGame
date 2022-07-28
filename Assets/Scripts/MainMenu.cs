using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject OptionMenu;
    [SerializeField] GameObject pauseGameMenu;
    bool GamePaused = false;

    void Update()
    {
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
    public void Play()
    {
        SceneManager.LoadScene("Level");
    }
    public void BackMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void OpenOption()
    {
        OptionMenu.SetActive(true);
    }

    public void CloseOption()
    {
        OptionMenu.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Игра Закрылась");
    }

}
