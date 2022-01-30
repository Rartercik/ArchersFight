using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
	public GameObject[] SpikesObjects;
	public int inTime;
    	
	public void SpawnSpikes()
	{
		foreach(var e in SpikesObjects)
		e.SetActive(true);
	}
}
