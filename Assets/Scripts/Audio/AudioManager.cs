using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private Sound[] sounds;
    void Awake()
    {

        foreach (Sound s in sounds)
        {
            s.setAudioSource(gameObject.AddComponent<AudioSource>());
            s.getAudioSource().clip = s.getAudioClip();
            s.getAudioSource().volume = s.getVolume();
            s.getAudioSource().pitch = s.getPitch();
            s.getAudioSource().loop = s.getLoop();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Play("Background");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void die()
    {
        Play("explosion");
    }

    public void shooter()
    {
        Play("shooter");
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.getName() == name);
        if (s == null)
        {
            Debug.LogWarning("sound" + name + " not found");
            return;
        }
        s.getAudioSource().Play();
    }
}
