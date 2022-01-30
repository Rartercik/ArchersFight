using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpButton : MonoBehaviour
{
	[SerializeField] PlayerMovement player;
	[SerializeField] float timeCount;
	private float timer;
	private bool firstClick;
	
	void Start()
	{
		timer = timeCount;
	}
	void FixedUpdate()
	{
		if(firstClick == true && timer > 0)
		{
			player.Jump();
			timer -= Time.fixedDeltaTime;
		}
	}
	public void StartJump()
	{
		if(player.JumpAvailable())
		{
			firstClick = true;
		}
	}
	public void EndJump()
	{
		firstClick = false;
		timer = timeCount;
	}
}
