using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicOnOff : MonoBehaviour
{
    private AudioSource audioSrc;
    bool m_Play;
    bool m_ToggleChange;

    public Toggle sel;


    void Start()
    {
        //.GetComponent<AudioSource>();
        audioSrc = GameObject.Find("MusicPlayer").GetComponent<AudioSource>();
        m_Play = true;
        m_ToggleChange = false;
        if (PlayerPrefs.GetInt("MusicToggle") == 1)
        {
            sel.isOn = true;
        }
        else
        {
            sel.isOn = false;
        }

    }
    public void OnChangeValue()
    {
            m_ToggleChange = true;

    }
    void Update()
    {
        if (m_ToggleChange == false && m_Play == true)
        {
            PlayerPrefs.SetInt("MusicToggle", 1);
        }

        if (m_ToggleChange == true && m_Play == false)
        {
            //Play the audio you attach to the AudioSource component
            audioSrc.Play();
            m_ToggleChange = false;
            m_Play = true;
            PlayerPrefs.SetInt("MusicToggle", 1);
            //Ensure audio doesn’t play more than once
        }
        if (m_ToggleChange == true && m_Play == true)
        {
            //Stop the audio
            audioSrc.Stop();
            m_ToggleChange = false;
            m_Play = false;
            PlayerPrefs.SetInt("MusicToggle", 0);
        }

    }

}
