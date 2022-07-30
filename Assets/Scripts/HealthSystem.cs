using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HealthSystem : MonoBehaviour
{
    [Header("DefaultHelthOption")]
    public int health;
    [SerializeField] private GameObject DestroyEffect;
    [SerializeField] private float delay;

    [Header("PlayerHealthOption")]
    public static Action isDead;
    public static Action playerGetDamage;
    [SerializeField] private bool isPlayer;

    [Header("EnemyHealthOption")]
    [SerializeField] private bool isEnemy;
    [SerializeField] private int addedPoints;
    public static Action<int> onDestroys;
    public static Action meteorGetDamage;


    private void Update()
    {
        if(health <= 0)
        {
            if (isEnemy)
            {
                onDestroys?.Invoke(addedPoints);
            }
            else if(isPlayer)
            {
                isDead?.Invoke();
            }
            GameObject effect = Instantiate(DestroyEffect, transform.position, Quaternion.identity);
            Destroy(effect, delay);
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        if (isEnemy)
        {
            meteorGetDamage?.Invoke();
        }
        else if (isPlayer)
        {
            playerGetDamage?.Invoke();
        }
        health -= damage;
    }
}
