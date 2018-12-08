using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class CharaterMove : MonoBehaviour 
{
	//Player Movement Variables
	public int moveSpeed;
	public float jumpHeight;
	private bool doublejump;
	//Player grounded variables
	public Transform groundedCheak;
	public float groundedCheakRadius;
	public LayerMask whatIsGround;
	private bool grounded;
	//Non-Stick Player
	private float moveVelocity;
	//Player Health
	public int MaxHealth;
	public int CurHealth;
	//player animation
	
	public Animator animator;

	// Use this for initialization
	void Start () 
	{
		animator.SetBool("IsWalking", false);
		animator.SetBool("IsCrouching", false);
		animator.SetBool("IsJumping", false);
	}
	void FixedUpdate() 
	{
		grounded = Physics2D.OverlapCircle(groundedCheak.position, groundedCheakRadius, whatIsGround);
	}
	
	// Update is called once per frame
	void Update () 
	{
		//This code makes the character jump
		if(Input.GetKeyDown(KeyCode.Space)&& grounded)
		{
			Jump();
		}
		//Double jump code
		if(grounded)
		{
			doublejump = false;
			animator.SetBool("IsJumping", false);
		}

		if(Input.GetKeyDown(KeyCode.Space)&& !doublejump && !grounded)
		{
			Jump();
			doublejump = true;
		}
		//Non-Stick Player;
		moveVelocity = 0f;
		//This code makes the charcter move from side to side using the A&D kyes
		if(Input.GetKey (KeyCode.D))
		{
			//GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			moveVelocity = moveSpeed;
			animator.SetBool("IsWalking", true);
		} 
		else if(Input.GetKeyUp (KeyCode.D))
		{
			animator.SetBool("IsWalking", false);
		}
		if(Input.GetKey (KeyCode.A))
		{
			//GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			moveVelocity = -moveSpeed;
			animator.SetBool("IsWalking", true);
		}
		else if(Input.GetKeyUp (KeyCode.A))
		{
			animator.SetBool("IsWalking", false);
		}
		if(Input.GetKey (KeyCode.S))
		{
			animator.SetBool("IsCrouching", true);
		}
		else if(Input.GetKeyUp (KeyCode.S))
		{
			animator.SetBool("IsCrouching", false);
		}
		animator.SetBool ("grounded", grounded);
		//animator.SetFloatC"VelocityX", Mathf.Abs (velocity.x) / moveSpeed);

		GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

		//Player Flip
		if (GetComponent<Rigidbody2D>().velocity.x > 0)
			transform.localScale = new Vector3(0.65f, 0.65f,1f);
		else if (GetComponent<Rigidbody2D>().velocity.x < 0)
			transform.localScale = new Vector3(-0.65f, 0.65f,1f);
		
	}
	public void Jump()
	{
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
		animator.SetBool("IsJumping", true);
	}

	[ExecuteInEditMode]
	void OnValidate()
	{
		CurHealth = Mathf.Clamp(CurHealth,0,MaxHealth);
	}
}
