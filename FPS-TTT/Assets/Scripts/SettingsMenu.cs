using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settingsMenu;
    public AudioMixer audioMixer;
    public bool playBackgroudMusicGlobal = true;
    public float volumeGlobal = -10;
    public void SetBgVolume(float volume)
    {
        if (playBackgroudMusicGlobal)
        {
            audioMixer.SetFloat("BgVolume", volume);
            volumeGlobal = volume;
        }
        else
        {
            volumeGlobal = volume;
        }
        
    }

    void Start()
    {
        audioMixer.GetFloat("BgVolume", out volumeGlobal);
    }

    public void PlayBackgroudMusic(bool playBackgroudMusic)
    {
        if (playBackgroudMusic)
        {
            audioMixer.SetFloat("BgVolume", volumeGlobal);
            playBackgroudMusicGlobal = true;
        }
        else
        {
            audioMixer.SetFloat("BgVolume", -80);
            playBackgroudMusicGlobal = false;
        }
    }

    public void GoBackToMainMenu()
    {
        settingsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
