using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeObjectScript : MonoBehaviour
{
	private void OnCollisionEnter2D(Collision2D other)
    {
    	if(other.gameObject.TryGetComponent(out PlayerInteraction player))
    	{
    		player.TakeDamage(player.Hp);
    	}
	}
}
