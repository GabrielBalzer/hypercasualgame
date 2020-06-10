using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class audioplayer : Singleton<audioplayer>
{
    public static audioplayer instance;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Awake()
    {
        
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(transform.gameObject);
        } else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void PauseAudio()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Pause();
        }
        else
        {
            audioSource.Play(0);
        }
    }

}
