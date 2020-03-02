using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static SoundManager instance;

    [SerializeField]
    private AudioSource soundFX, soundShoot, timeEffect, nocoolDown;

    [SerializeField]
    private AudioClip shootClip, deathClip, gameOverClip, slowDownClip, normalTimeClip, noCoolDownClip;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void ShootSound()
    {
        soundShoot.clip = shootClip;
        soundShoot.Play();
    }
    public void DeathSound()
    {
        soundFX.clip = deathClip;
        soundFX.Play();
    }
    public void GameOverSound()
    {
        soundFX.clip = gameOverClip;
        soundFX.Play();
    }

    public void SlowDownSound()
    {
        timeEffect.clip = slowDownClip;
        timeEffect.Play();
    }
    public void NormalSound()
    {
        timeEffect.clip = normalTimeClip;
        timeEffect.Play();
    }
    public void NoCoolDown()
    {
        nocoolDown.clip = noCoolDownClip;
        nocoolDown.Play();
    }

}
