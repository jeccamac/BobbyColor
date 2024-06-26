using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    /*
    Reference AudioManager from anywhere by using: AudioManager.Instance.PlayMusic("Name") or PlaySFX("Name")
    Stop playing music: AudioManager.Instance.musicSource.Stop();
    */
    public static AudioManager Instance;

    [Header("Audio Settings")]
    [SerializeField] public Sound[] musicSounds, sfxSounds;
    [SerializeField] public AudioSource musicSource, sfxSource;
    private void Awake() 
    {
        if (Instance == null) //singleton
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void Start() 
    {
        PlayMusic("Theme");
    }

    public void PlayMusic(string name)
    {
        Sound sound = Array.Find(musicSounds, x => x.name == name); //find

        if (sound != null)
        {
            musicSource.clip = sound.clip;
            musicSource.Play();
        } else { Debug.Log("Music Not Found"); }
    }

    public void PlaySFX(string name)
    {
        Sound sound = Array.Find(sfxSounds, x => x.name == name);
        if (sound != null)
        {
            sfxSource.PlayOneShot(sound.clip);
        } else { Debug.Log("SFX Not Found"); }
    }

    public void StopSFX(string name)
    {
        Sound sound = Array.Find(sfxSounds, x => x.name == name);

        if (sound != null)
        {
            sfxSource.Stop();
        }
    }

    public void ToggleMusic()
    {
        musicSource.mute = !musicSource.mute;
    }

    public void ToggleSFX()
    {
        sfxSource.mute = !sfxSource.mute;
    }

    public void MusicVolume(float volume)
    {
        musicSource.volume = volume;
    }

    public void SFXVolume(float volume)
    {
        sfxSource.volume = volume;
    }
}
