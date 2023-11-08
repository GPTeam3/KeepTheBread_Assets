using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System.Collections;

public class SoundButton : MonoBehaviour
{
    public GameObject obj;
    AudioSource gamesound;

    void Start()
    {
        gamesound = obj.GetComponent<AudioSource>();
        gamesound.loop = true;
        Screen.SetResolution(1080, 1920, true);

        Screen.SetResolution(Screen.width, (Screen.width * 16) / 9, true);
    }

    public void SoundOn()
    {
        gamesound.volume = 1.0f;
    }

    public void SoundOff()
    {
        gamesound.volume = 0.0f;
    }
}
