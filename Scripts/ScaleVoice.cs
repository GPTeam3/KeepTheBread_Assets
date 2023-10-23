using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleVoice : MonoBehaviour
{
    public Slider sound;

    public AudioSource source;
    public Vector3 minScale;
    public Vector3 maxScale;
    public AudioLoudnessDetection detector;

    public float loudnessSensibility = 100;
    public float threshold = 0.1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ItemManager.isItemVoice)
        {
            float loudness = detector.GetLoudnessFromMicrophone() * loudnessSensibility;
            sound.value = loudness / 20f;
        }
    }
}
