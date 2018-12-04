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
		print("Hello World!");
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
			animator.SetFloat("Speed", moveSpeed);
		} 
		if(Input.GetKey (KeyCode.A))
		{
			//GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			moveVelocity = -moveSpeed;
			
		}
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
	}

	[ExecuteInEditMode]
	void OnValidate()
	{
		CurHealth = Mathf.Clamp(CurHealth,0,MaxHealth);
	}
}
