using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    [SerializeField] private GameObject OptionMenu;
    [SerializeField] private GameObject AudioOption;
    [SerializeField] private GameObject GraphicalOption;
    public void Play()
    {
        SceneManager.LoadScene("Level");
    }
    public void BackMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void OpenAudioOption()
    {
        OptionMenu.SetActive(false);
        AudioOption.SetActive(true);
    }

    public void OpenGraphicalOption()
    {
        OptionMenu.SetActive(false);
        GraphicalOption.SetActive(true);
    }

    public void BackToDefOption()
    {
        OptionMenu.SetActive(true);
        AudioOption.SetActive(false);
        GraphicalOption.SetActive(false);
    }

    public void OpenOption()
    {
        OptionMenu.SetActive(true);
    }

    public void CloseOption()
    {
        AudioOption.SetActive(false);
        OptionMenu.SetActive(false);
        GraphicalOption.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Игра Закрылась");
    }

}
