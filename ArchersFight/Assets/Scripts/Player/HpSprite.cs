using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpSprite : MonoBehaviour
{
	private SpriteRenderer spriteRenderer;
	[SerializeField] Sprite fullHeart;
	[SerializeField] Sprite hollowHeart;
	
	void Start()
	{
		spriteRenderer = GetComponent<SpriteRenderer>();
	}
	public void MinusHp()
	{
		spriteRenderer.sprite = hollowHeart;
	}
	public void PlusHp()
	{
		spriteRenderer.sprite = fullHeart;
	}
}
