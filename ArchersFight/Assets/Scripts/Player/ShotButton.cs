using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotButton : MonoBehaviour
{
	[SerializeField] PlayerMovement player;
	
	public void Shoot()
	{
		if(player.ShootAvailable())
			player.Shoot();
	}
}
