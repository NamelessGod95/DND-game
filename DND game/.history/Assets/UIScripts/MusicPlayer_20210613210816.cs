﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MusicPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource Musi;
    public Slider volumer;
    private float musicVolume = 0.5f;

    void Start()
    {
       Musi.Play();
       musicVolume = PlayerPrefs.getFloat("volume");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(musicVolume);
        Musi.volume = musicVolume;
        PlayerPrefs.setFloat("volume", musicVolume)
    }

        public void updateVolume(float volume ){
        musicVolume = volume;
    }
}
