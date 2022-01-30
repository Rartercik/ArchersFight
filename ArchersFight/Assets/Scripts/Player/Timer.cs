using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
	[SerializeField] Spikes[] spikes;
	[SerializeField] int seconds;
	[SerializeField] TimeToGameEnd endEvent;
	
	private Text text;
	private float oneSecond = 1f;
	
    void Start()
    {
    	text = GetComponent<Text>();
    }
    
    void Update()
    {
    	if(seconds > 0)
    	{
    		var spike = Array.Find(spikes, x => x.inTime == seconds);
    		if(spike != null)
    			spike.SpawnSpikes();
    		ExecuteEverySecond();
    	}
    	else
    	{
    		endEvent.ChangeTime(0);
    		endEvent.gameObject.SetActive(true);
    	}
    }
    
    private void ExecuteEverySecond()
	{
    	
    	if(oneSecond > 0)
    	{
    		oneSecond -= Time.deltaTime;
    	}
    	else
    	{
    		oneSecond = 1f;
    		seconds -= 1;
    	
    		var minutes = seconds/60;
    		var tenSeconds = seconds%60/10;
    		var singleSeconds = seconds%10;
    		
    		text.text = string.Format("{0}:{1}{2}", minutes, tenSeconds, singleSeconds);
    	}
	}
}
