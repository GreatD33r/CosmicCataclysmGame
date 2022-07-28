using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int health;
    [SerializeField] private GameObject DestroyEffect;
    [SerializeField] private float delay;
    /*[SerializeField] private bool isEnemy;
    [SerializeField] StuffManager StuffManager;
    [SerializeField] private int addedPoints;*/

    /*private void Start()
    {
        StuffManager = FindObjectOfType<StuffManager>();
    }*/

    private void Update()
    {
        if(health <= 0)
        {
            /*if (isEnemy)
            {
                StuffManager.LevelProgres += addedPoints;
            }*/
            GameObject effect = Instantiate(DestroyEffect, transform.position, Quaternion.identity);
            Destroy(effect, delay);
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
