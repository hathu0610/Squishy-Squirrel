using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXScript : MonoBehaviour
{
    public AudioClip homesound;
    public void OnMouseDown()
    {
        // load a new scene
        AudioSource.PlayClipAtPoint(homesound, new Vector3(5, 1, 2));

    }
}
