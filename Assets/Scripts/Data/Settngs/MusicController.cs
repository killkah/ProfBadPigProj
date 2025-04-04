using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicController : MonoBehaviour
{
    [SerializeField] private AudioMixer mixer;
    public void ChangeVolume()
    {
        int x = PlayerPrefs.GetInt("Volume");

        if(x == 0)
        {
            mixer.SetFloat("MasterVolume", 20);
        }
        else
        {
            mixer.SetFloat("MasterVolume", -80);
        }
    }
}
