using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveButton : MonoBehaviour
{
	[SerializeField] PlayerMovement player;
	[SerializeField] Diraction diraction;
	[SerializeField] MoveButton anotherButton;
	
	public bool moveAble { get; private set; }
	
    void FixedUpdate()
    {
    	if(moveAble == true)
        	player.Move(diraction);
    }
    public void MovePlayer()
    {
    	if(anotherButton.moveAble == false)
    	{
    		moveAble = true;
    	}
    }
    public void StopPlayer()
    {
    	if(anotherButton.moveAble == false)
    	{
    		moveAble = false;
    		player.Idle();
    	}
    }
}
