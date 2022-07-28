using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StuffManager : MonoBehaviour
{
    public float LevelProgres;
    [SerializeField] private Slider ProgressBar;


    private void Update()
    {
        ProgressBar.value = LevelProgres;
    }
}
