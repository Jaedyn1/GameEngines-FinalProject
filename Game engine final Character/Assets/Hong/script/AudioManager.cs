using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioClip sfx;
    public AudioSource audio;
    public void Awake()
    {
        instance = this;


        DontDestroyOnLoad(gameObject);

    }



}

