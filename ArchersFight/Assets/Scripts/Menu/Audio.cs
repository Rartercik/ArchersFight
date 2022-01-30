using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource audioSource;
    public float maxVolume;
    
    [SerializeField] MusicOrSounds musicOrSounds;
    
    void Awake()
    {
    	audioSource = GetComponent<AudioSource>();
    	maxVolume = audioSource.volume;
    	audioSource.volume = maxVolume * (musicOrSounds == MusicOrSounds.Music ? GlobalVolume.MusicVolume : GlobalVolume.SoundsVolume);
    }
}