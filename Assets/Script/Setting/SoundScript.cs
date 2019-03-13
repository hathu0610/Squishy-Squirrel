using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundScript : MonoBehaviour
{
    private AudioSource audioSrc;
    private static SoundScript instance = null;
    GameObject musicbackground;
    void Start()
    {
        musicbackground = GameObject.Find("MusicPlayer");
        //.GetComponent<AudioSource>();
        audioSrc = musicbackground.GetComponent<AudioSource>();
        audioSrc.volume = PlayerPrefs.GetFloat("SoundSlider", audioSrc.volume);
        Debug.Log(PlayerPrefs.GetFloat("SoundSlider", audioSrc.volume));
      
    }
    void Update()
    {
        audioSrc.volume = PlayerPrefs.GetFloat("SoundSlider", audioSrc.volume);

    }

    public static SoundScript Instance
    {
        get { return Instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
