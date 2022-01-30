using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
	[SerializeField] Text anotherButton;
	[SerializeField] GameObject sceneTransition;
	[SerializeField] int sceneNumber;
	[SerializeField] AudioClip sound;
	
	private Text thisButton;
	private Animator transitionAnimator;
	private SceneChange transitionScript;
	private AudioSource audio;
	
    void Start()
    {
    	thisButton = GetComponent<Text>();
    	transitionAnimator = sceneTransition.GetComponent<Animator>();
    	transitionScript = sceneTransition.GetComponent<SceneChange>();
    	audio = GetComponent<AudioSource>();
    }
    
    public void Click()
    {
    	audio.PlayOneShot(sound, 1);
    	if(thisButton.color != Color.yellow)
    	{
    		anotherButton.color = Color.white;
    		thisButton.color = Color.yellow;
    	}
    	else if(transitionAnimator.GetCurrentAnimatorStateInfo(0).IsName("InScene"))
    	{
    		transitionScript.ChangeSceneNumber(sceneNumber);
    		transitionAnimator.SetTrigger("LeaveScene");
    	}
    }
}
