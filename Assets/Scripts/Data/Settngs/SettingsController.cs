using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SettingsController : MonoBehaviour
{
    [SerializeField] private Dropdown resolution;
    [SerializeField] private Toggle widnowMode;
    [SerializeField] private Toggle sounds;
    [SerializeField] private Dropdown language;

    [SerializeField] private MusicController musicController;

    [SerializeField] private SettingsData settingsData;
    [SerializeField] private DefaultSettingsData defaultSettingsData;


    private void Start()
    {
        LoadSettings();
    }
    public void LoadSettings()
    {
        resolution.value = settingsData.resolutionValue;
        widnowMode.isOn = settingsData.windowModeValue;
        sounds.isOn = settingsData.soundsValue;
        language.value = settingsData.languageValue;

        SaveSettings();
    }
    public void SaveSettings()
    {
        settingsData.resolutionValue = resolution.value;
        settingsData.windowModeValue = widnowMode.isOn;
        settingsData.soundsValue = sounds.isOn;
        settingsData.languageValue = language.value;

        switch (settingsData.resolutionValue)
        {
            case 0:
                Screen.SetResolution(1280, 720, settingsData.windowModeValue);
                break;
            case 1:
                Screen.SetResolution(1366, 768, settingsData.windowModeValue);
                break;
            case 2:
                Screen.SetResolution(1600, 900, settingsData.windowModeValue);
                break;
            case 3:
                Screen.SetResolution(1920, 1080, settingsData.windowModeValue);
                break;
        }

        if(settingsData.soundsValue == true)
        {
            PlayerPrefs.SetInt("Volume", 0);
        }
        else
        {
            PlayerPrefs.SetInt("Volume", 1);
        }

        musicController.ChangeVolume();
    }
    public void ResetSettings()
    {
        resolution.value = defaultSettingsData.resolutionValue;
        widnowMode.isOn = defaultSettingsData.windowModeValue;
        sounds.isOn = defaultSettingsData.soundsValue;
        language.value = defaultSettingsData.languageValue;
        SaveSettings();
    }
}