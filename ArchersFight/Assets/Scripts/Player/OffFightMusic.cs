using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffFightMusic : MonoBehaviour
{
	[SerializeField] float timeToOffVolume;
	
	private AudioSource audioSource;
	private float maxVolume;
	private bool start = false;
	
	void Start()
	{
		audioSource = GetComponent<AudioSource>();
		maxVolume = GetComponent<Audio>().maxVolume;
	}
	
	void Update()
	{
		if(start == true)
		{
			if(audioSource.volume > 0)
				audioSource.volume -= (Time.fixedDeltaTime/timeToOffVolume)*maxVolume;
		}
	}
	
	public void OffMusic()
	{
		start = true;
	}
}
