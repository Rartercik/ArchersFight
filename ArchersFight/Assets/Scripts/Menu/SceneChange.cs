using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
	[SerializeField] int sceneNumber;
	
	public void ChangeScene()
	{
		SceneManager.LoadScene(sceneNumber);
	}
	public void ChangeSceneNumber(int number)
	{
		sceneNumber = number;
	}
}
