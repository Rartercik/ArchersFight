using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeToGameEnd : MonoBehaviour
{
	[SerializeField] float time;
	[SerializeField] GameObject player1;
	[SerializeField] GameObject player2;
	[SerializeField] GameObject drawSpawner;
	[SerializeField] GameObject winSpawner;
	[SerializeField] Text winText;
	[SerializeField] OffFightMusic music;
	
    void Start()
    {
    	StartCoroutine(Waiting());
    }
    public void ChangeTime(float value)
    {
    	time = value;
    }
    public void Draw()
    {
    	drawSpawner.SetActive(true);
    	Time.timeScale = 0;
    }
    public void Win(string playerName)
    {
    	winSpawner.SetActive(true);
    	winText.text = string.Format(playerName + " Win!");
    	Time.timeScale = 0;
    }
    private IEnumerator Waiting()
    {
    	yield return new WaitForSeconds(time);
    	music.OffMusic();
    	if((player1.activeSelf == false && player2.activeSelf == false) || (player1.activeSelf == true && player2.activeSelf == true))
    		Draw();
    	else
    		Win(player1.activeSelf == true ? "Player1" : "Player2");
    }
}
