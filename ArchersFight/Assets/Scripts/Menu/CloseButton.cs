using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
	[SerializeField] Animator[] menu;
	
	public void StartClosing()
	{
		foreach(var e in menu)
			e.SetTrigger("Do");
	}
}
