using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikerScript : MonoBehaviour
{
	[SerializeField] GameObject spike;
	
	public void AwakeSpike()
	{
		spike.SetActive(true);
	}
}
