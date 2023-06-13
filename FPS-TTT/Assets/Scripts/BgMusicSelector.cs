using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BgMusicSelector : MonoBehaviour
{

    public AudioSource Track1;
    public AudioSource Track2;
    public AudioSource Track3;
    public AudioSource Track4;
    public AudioSource Track5;

    public int TrackSelector;
    public int TrackHistory;
    public SettingsMenu settingsMenu;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(settingsMenu.playBackgroudMusicGlobal);
        if (settingsMenu.playBackgroudMusicGlobal == true )
        {
            TrackSelector = Random.Range(0, 4);

            if (TrackSelector == 0)
            {
                Track1.Play();
                TrackHistory = 0;
            }
            else if (TrackSelector == 1)
            {
                Track2.Play();
                TrackHistory = 1;
            }
            else if (TrackSelector == 2)
            {
                Track3.Play();
                TrackHistory = 2;
            }
            else if (TrackSelector == 3)
            {
                Track4.Play();
                TrackHistory = 3;
            }
            else if (TrackSelector == 4)
            {
                Track5.Play();
                TrackHistory = 4;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Track1.isPlaying == false && Track2.isPlaying == false && Track3.isPlaying == false && Track4.isPlaying == false && Track5.isPlaying == false && settingsMenu.playBackgroudMusicGlobal == true)
        {
            TrackSelector = Random.Range(0, 4);

            if (TrackSelector == 0 && TrackHistory !=0)
            {
                Track1.Play();
                TrackHistory = 0;
            }
            else if (TrackSelector == 1 && TrackHistory !=1 && false)
            {
                Track2.Play();
                TrackHistory = 1;
            }
            else if (TrackSelector == 2 && TrackHistory != 2)
            {
                Track3.Play();
                TrackHistory = 2;
            }
            else if (TrackSelector == 3 && TrackHistory != 3)
            {
                Track4.Play();
                TrackHistory = 3;
            }
            else if (TrackSelector == 4 && TrackHistory != 4)
            {
                Track5.Play();
                TrackHistory = 4;
            }
        }
    }
}
