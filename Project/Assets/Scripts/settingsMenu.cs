using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class settingsMenu : MonoBehaviour
{
    public TMPro.TMP_Dropdown OGMode;
    public bool OGOn;
    public bool OGPermanent;

    public AudioMixer audioMixer;
    public Slider masterVolume;
    public Slider gameplayVolume;
    public Slider ambienceVolume;
    public Slider sfxVolume;
    public Slider musicVolume;


    public void OGActiveMode()
    {
        PlayerPrefs.SetInt("OGMode", OGMode.value);
    }

    public void HighScoreReset()
    {
        PlayerPrefs.SetInt("HighScore2", 0);
        PlayerPrefs.SetInt("HighScore3", 0);
        PlayerPrefs.SetInt("HighScore4", 0);
        PlayerPrefs.SetInt("HighScore1", 0);
        PlayerPrefs.SetString("HS1Name", "n/a");
        PlayerPrefs.SetString("HS2Name", "n/a");
        PlayerPrefs.SetString("HS3Name", "n/a");
        PlayerPrefs.SetString("HS4Name", "n/a");
    }

    public void MasterVolume()
    {
        PlayerPrefs.SetFloat("masterAudio", masterVolume.value);
    }

    public void GameplayVolume()
    {
        PlayerPrefs.SetFloat("gameplayAudio", gameplayVolume.value);
    }

    public void AmbienceVolume()
    {
        PlayerPrefs.SetFloat("ambienceAudio", ambienceVolume.value);
    }

    public void SFXVolume()
    {
        PlayerPrefs.SetFloat("sfxAudio", sfxVolume.value);
    }

    public void MusicVolume()
    {
        PlayerPrefs.SetFloat("musicAudio", musicVolume.value);
    }

    public void Update()
    {
        masterVolume.value = PlayerPrefs.GetFloat("masterAudio", 0);
        gameplayVolume.value = PlayerPrefs.GetFloat("gameplayAudio", 0);
        ambienceVolume.value = PlayerPrefs.GetFloat("ambienceAudio", 0);
        sfxVolume.value = PlayerPrefs.GetFloat("sfxAudio", 0);
        musicVolume.value = PlayerPrefs.GetFloat("musicAudio", 0);
        audioMixer.SetFloat("masterVol", Mathf.Log10(PlayerPrefs.GetFloat("masterAudio", 0)) * 20);
        audioMixer.SetFloat("gameplayVol", Mathf.Log10(PlayerPrefs.GetFloat("gameplayAudio", 0)) * 20);
        audioMixer.SetFloat("ambienceVol", Mathf.Log10(PlayerPrefs.GetFloat("ambienceAudio", 0)) * 20);
        audioMixer.SetFloat("sfxVol", Mathf.Log10(PlayerPrefs.GetFloat("sfxAudio", 0)) * 20);
        audioMixer.SetFloat("musicVol", Mathf.Log10(PlayerPrefs.GetFloat("musicAudio", 0)) * 20);
    }
}
