using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioUi : MonoBehaviour
{
    public AudioClip sfx;

    public void playaudio()
    {
        AudioManager.instance.audio.clip = sfx;
        AudioManager.instance.audio.Play();
    }
}
