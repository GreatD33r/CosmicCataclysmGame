using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StuffManager : MonoBehaviour
{
    public float LevelProgres;
    [SerializeField] private Slider ProgressBar;

    private void OnEnable()
    {
        HealthSystem.onDestroys += AddScore;
    }

    private void OnDisable()
    {
        HealthSystem.onDestroys -= AddScore;
    }

    void AddScore(int points)
    {
        LevelProgres += points;
        ProgressBar.value = LevelProgres;
        if (ProgressBar.value == ProgressBar.maxValue)
        {
            SceneManager.LoadScene("Menu");
        }
    }

}
