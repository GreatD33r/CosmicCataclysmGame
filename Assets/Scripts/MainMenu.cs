using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject OptionMenu;

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
