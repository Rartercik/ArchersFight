using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
	[SerializeField] Animator sceneChange;
	
	public void ChangeScene()
	{
		sceneChange.SetTrigger("LeaveScene");
	}
}
