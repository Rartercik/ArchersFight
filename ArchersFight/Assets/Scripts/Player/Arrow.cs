using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
	private Rigidbody2D rb2D;
	
	[SerializeField] float speed;
	[SerializeField] int damage;
	[SerializeField] GameObject particleByObject;
	[SerializeField] GameObject particleByPlayer;
	
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        rb2D.velocity = transform.up * speed;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
    	if(other.gameObject.TryGetComponent(out PlayerInteraction player))
    	{
    		player.TakeDamage(damage);
    		Instantiate(particleByPlayer, transform.position, transform.rotation);
    		gameObject.SetActive(false);
    	}
    	else
    	{
    		Instantiate(particleByObject, transform.position, transform.rotation);
    		gameObject.SetActive(false);
    	}
    }
}
