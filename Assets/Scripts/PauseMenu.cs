using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject OptionMenu;
    [SerializeField] GameObject pauseGameMenu;
    [SerializeField] GameObject deadMenu;
    /*[SerializeField] AudioSource Effects;
    [SerializeField] private AudioClip DeadSound;
    [SerializeField] AudioSource Music;*/
    bool playerDead = false;
    bool GamePaused = false;

    private void OnEnable()
    {
        HealthSystem.isDead += Dead;
    }

    private void OnDestroy()
    {
        HealthSystem.isDead -= Dead;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused & !playerDead)
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
        OptionMenu.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }
    void Dead()
    {
        /*Effects.PlayOneShot(DeadSound);
        Music.mute = true;*/
        deadMenu.SetActive(true);
        playerDead = true;
        Time.timeScale = 0f;
    }

    public void Pause()
    {
        pauseGameMenu.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }
}
