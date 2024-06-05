using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicMenu : MonoBehaviour
{
    [SerializeField] private AudioSource musicClip;

    public void Mute () 
    {
        musicClip.Pause();
    }

    public void MusicOn()
    {
        musicClip.Play();
    }

}
