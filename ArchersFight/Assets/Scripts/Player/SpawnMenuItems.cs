using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMenuItems : MonoBehaviour
{
	[SerializeField] GameObject[] items;
	
	public void SpawnMenu()
	{
		foreach(var e in items)
			e.SetActive(true);
	}
}
