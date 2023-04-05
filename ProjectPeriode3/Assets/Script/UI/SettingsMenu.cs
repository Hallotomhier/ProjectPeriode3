using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public float volume;
    public bool fullscreenToggle;
    public AudioMixer audioMixer;

    public void SetVolume()
    {
        audioMixer.SetFloat("volume", volume);
        Debug.Log(volume);
    }

    public void SetFullScreen()
    {
        Screen.fullScreen = fullscreenToggle;
        Debug.Log("Fullscreen succesfully toggled");
    }
}
