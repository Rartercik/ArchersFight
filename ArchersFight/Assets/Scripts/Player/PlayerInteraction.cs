using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
	[SerializeField] HpSprite[] HpSprites;
	[SerializeField] Button[] buttons;
	[SerializeField] GameObject dieParticle;
	[SerializeField] GameObject endingStarter;
	
	private Animator animator;
	private BoxCollider2D collider;
	private int hp;
	
	void Start()
	{
		animator = GetComponent<Animator>();
		collider = GetComponent<BoxCollider2D>();
		Hp = HpSprites.Length;
	}
	
	public int Hp
	{
		get
		{
			return hp;
		}
		private set
		{
			hp = value < 0 ? 0 : value;
		}
	}
	
	public void TakeDamage(int damage)
	{
		var hpInMoment = Hp;
		Hp -= damage;
		for(int i = hpInMoment-1; i > Hp-1; i--)
			HpSprites[i].MinusHp();
		if(Hp <= 0)
			OnDead();
	}
	
	private void OnDead()
	{
		if(animator.GetCurrentAnimatorStateInfo(0).IsName("Die") == false)
		{
			SwitchOffButtons();
			animator.SetTrigger("Die");
			collider.size = new Vector2(collider.size.x, 0.1f);
		}
	}
	
	private void SwitchOffButtons()
	{
		foreach(var e in buttons)
    		e.enabled = false;
	}
	
	private void DestroyPlayer()
	{
		Instantiate(dieParticle, transform.position, dieParticle.transform.rotation);
		endingStarter.SetActive(true);
		gameObject.SetActive(false);
	}
}
