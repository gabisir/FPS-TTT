using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public bool playBackgroudMusicGlobal = true;
    public void SetBgVolume(float volume)
    {
        audioMixer.SetFloat("BgVolume", volume);
    }

    public void PlayBackgroudMusic(bool playBackgroudMusic)
    {
        playBackgroudMusicGlobal = playBackgroudMusic;
    }
}
