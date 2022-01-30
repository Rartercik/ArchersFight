using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
	[SerializeField] GameObject arrow;
	
	public void Shoot()
	{
		var weaponRotation = transform.rotation;
		var weaponPosition = transform.position;
		Instantiate(arrow, new Vector2(weaponPosition.x, weaponPosition.y), Quaternion.Euler(0, 0, weaponRotation.y == 0 ? -90 : 90));
	}
}
