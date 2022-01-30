using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField] float velocity;
	[SerializeField] float jumpForce;
	[SerializeField] Weapon weapon;
	[SerializeField] SpriteRenderer playerInscription;
	[SerializeField] float timerForJump;
	
	private Rigidbody2D rb2D;
	private Animator animator;
	private bool flipLeft;
	private bool flipRight;
	private bool availableJumpAfterFall;
	private float timerJumpCount;
	
    void Start()
    {
    	rb2D = GetComponent<Rigidbody2D>();
    	animator = GetComponent<Animator>();
    	flipLeft = transform.rotation == Quaternion.Euler(0, 0, 0) ? true : false;
    	flipRight = flipLeft == true ? false : true;
    	timerJumpCount = timerForJump;
    }
    void Update()
    {
    	if(availableJumpAfterFall == true && timerForJump > 0)
    	{
    		timerForJump -= Time.deltaTime;
    	}
    	else
    	{
    		availableJumpAfterFall = false;
    		timerForJump = timerJumpCount;
    	}
    }
    private void OnCollisionStay2D(Collision2D other)
    {
    	if(other.gameObject.TryGetComponent(out PlatformEffector2D platform))
    		animator.SetBool("Jump", false);
    }
    private void OnCollisionExit2D(Collision2D other)
    {
    	if(other.gameObject.TryGetComponent(out PlatformEffector2D platform))
    		availableJumpAfterFall = true;
    }
    
    public void Idle()
    {
    	animator.SetBool("Move", false);
    	rb2D.velocity = new Vector2(0, rb2D.velocity.y);
    }
    public void Jump()
    {
    	rb2D.velocity = new Vector2(rb2D.velocity.x, jumpForce * Time.fixedDeltaTime);
    	animator.SetBool("Move", false);
    	animator.SetBool("Jump", true);
    }
    public void Move(Diraction diraction)
    {
    	if(diraction == Diraction.Left)
    	{
    		transform.rotation = Quaternion.Euler(0, 180, 0);
    		playerInscription.flipX = flipLeft;
    	}
    	else
    	{
    		transform.rotation = Quaternion.Euler(0, 0, 0);
    		playerInscription.flipX = flipRight;
    	}
    	rb2D.velocity = new Vector2(velocity * (int)diraction, rb2D.velocity.y);
    	animator.SetBool("Move", true);
    }
    public void Shoot()
    {
    	animator.SetTrigger("Shoot");
    }
    public void SpawnArrow()
    {
    	weapon.Shoot();
    }
    public bool JumpAvailable()
    {
    	return (animator.GetBool("Jump") == false && rb2D.velocity.y == 0) || 
    		(animator.GetBool("Jump") == false && rb2D.velocity.y <= 0 && availableJumpAfterFall == true);
    }
    public bool ShootAvailable()
    {
    	return !animator.GetCurrentAnimatorStateInfo(0).IsName("Shot");
    }
    
}
public enum Diraction
{
	Left = -1,
	Right = 1
}
