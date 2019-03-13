using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSlider : MonoBehaviour
{
    private AudioSource audioSrc;
    private float musicVolume;
    // Start is called before the first frame update
    void Start()
    {
        //.GetComponent<AudioSource>();
        audioSrc = GameObject.Find("MusicPlayer").GetComponent<AudioSource>();
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
        audioSrc.volume = musicVolume;
    }
}