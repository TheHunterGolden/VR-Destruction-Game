using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour {
    public Sound[] sounds;
    public float gap;
    private float startTime;

    private void Awake()
    {
        startTime = -100f;
        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }


    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }

    public void setTime()
    {
        startTime = Time.time;
    }

    public float getTime()
    {
        return startTime;
    }

    public float getGap()
    {
        return gap;
    }
}
