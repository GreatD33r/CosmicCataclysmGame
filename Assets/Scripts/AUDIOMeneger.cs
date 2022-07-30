using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AUDIOMeneger : MonoBehaviour
{
    [SerializeField] AudioSource Effects;
    [SerializeField] AudioSource Music;
    [SerializeField] AudioClip meteorDestroySound;
    [SerializeField] AudioClip meteorDamageSound;
    [SerializeField] AudioClip playerDestroySound;
    [SerializeField] AudioClip playerDamageSound;
    [SerializeField] AudioClip GameOverSound;
    [SerializeField] AudioClip ShootSound;

    private void OnEnable()
    {
        HealthSystem.onDestroys += meteorDestroy;
        HealthSystem.isDead += playerDestroy;
        HealthSystem.playerGetDamage += playerDamage;
        HealthSystem.meteorGetDamage += meteorDamage;
        Gun.Shoot += playShootSound;
    }

    private void OnDisable()
    {
        HealthSystem.onDestroys -= meteorDestroy;
        HealthSystem.isDead -= playerDestroy;
        HealthSystem.playerGetDamage -= playerDamage;
        HealthSystem.meteorGetDamage -= meteorDamage;
        Gun.Shoot -= playShootSound;
    }

    void playShootSound()
    {
        Effects.PlayOneShot(ShootSound);
    }

    void GameOver()
    {
        Effects.PlayOneShot(GameOverSound);
    }

    void meteorDamage()
    {
        Effects.PlayOneShot(meteorDamageSound);
    }

    void meteorDestroy(int f)
    {
        Effects.PlayOneShot(meteorDestroySound);
    }

    void playerDamage()
    {
        Effects.PlayOneShot(playerDamageSound);
    }

    void playerDestroy()
    {
        Music.mute = true;
        Effects.PlayOneShot(playerDestroySound);
    }

}
