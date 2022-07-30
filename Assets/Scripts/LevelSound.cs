using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSound : MonoBehaviour
{
    private static readonly string MusicPref = "MusicPref";
    private static readonly string SoundEffectsPref = "SoundEffectsPref";
    private float musicFloat, soundEffectsFloat;
    public AudioSource[] musicAudio;
    public AudioSource[] soundEffectsAudio;

    private void Awake()
    {
        LevelSoundSettings();
    }

    private void LevelSoundSettings()
    {
        musicFloat = PlayerPrefs.GetFloat(MusicPref);
        soundEffectsFloat = PlayerPrefs.GetFloat(SoundEffectsPref);

        for (int i = 0; i < musicAudio.Length; i++)
        {
            musicAudio[i].volume = soundEffectsFloat;
        }

        for (int i = 0; i < soundEffectsAudio.Length; i++)
        {
            soundEffectsAudio[i].volume = soundEffectsFloat;
        }
    }
}
