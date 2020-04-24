using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public GameObject SettingsMenuUi, PauseMenuUi;

 

    private void Start()
    {
       
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void SetScreenResFull()
    {
        Screen.SetResolution(1920, 1080, true);
    }

    public void SetScreenResWindow()
    {
        Screen.SetResolution(1280, 720, false);
    }

    public void SettingPlay()
    {
        PauseMenuUi.SetActive(true);
        SettingsMenuUi.SetActive(false);
        

    }

}
