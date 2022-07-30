using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider healthSlider;
    [SerializeField] private HealthSystem PlayerHealth;
    


    private void Start()
    {
        healthSlider.maxValue = PlayerHealth.health;
    }


    private void Update()
    {
        healthSlider.value = PlayerHealth.health;
    }
}
