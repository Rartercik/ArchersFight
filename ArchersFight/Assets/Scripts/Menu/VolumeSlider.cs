using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
	[SerializeField] MusicOrSounds musicOrSounds;
	[SerializeField] Audio[] audios;
	
    private Slider slider;
	
    void Start()
    {
    	slider = GetComponent<Slider>();
    	slider.value = (musicOrSounds == MusicOrSounds.Music ? GlobalVolume.MusicVolume : GlobalVolume.SoundsVolume)*100;
    }
    
    public void ChangeGlobalMusic()
    {
    	GlobalVolume.MusicVolume = slider.value/100;
    	foreach(var e in audios)
    		e.audioSource.volume = e.maxVolume * GlobalVolume.MusicVolume;
    }
    public void ChangeGlobalSounds()
    {
    	GlobalVolume.SoundsVolume = slider.value/100;
    	foreach(var e in audios)
    		e.audioSource.volume = e.maxVolume * GlobalVolume.SoundsVolume;
    }
}

public enum MusicOrSounds
{
	Music,
	Sounds
}
