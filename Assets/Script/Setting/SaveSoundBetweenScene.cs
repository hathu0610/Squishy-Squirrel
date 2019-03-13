using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveSoundBetweenScene : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider soundSlider;
    void Start()
    {
        soundSlider.value = PlayerPrefs.GetFloat("SoundSlider");
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("SoundSlider", soundSlider.value);
    }
}
