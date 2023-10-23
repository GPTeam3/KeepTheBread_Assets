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
        gamesound.Play();

        gamesound.volume = 1.0f;
        gamesound.loop = true;
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
