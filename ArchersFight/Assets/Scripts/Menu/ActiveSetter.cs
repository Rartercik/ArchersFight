using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveSetter : MonoBehaviour
{
	[SerializeField] GameObject[] objects;
	[SerializeField] bool active;
	
	public void SetActivity()
	{
		foreach(var e in objects)
			e.SetActive(active);
	}
}
