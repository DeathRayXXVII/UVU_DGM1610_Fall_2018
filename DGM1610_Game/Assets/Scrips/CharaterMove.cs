﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
		} 
		if(Input.GetKey (KeyCode.A))
		{
			//GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			moveVelocity = -moveSpeed;
		}
		GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);
		
	}
	public void Jump()
	{
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
	}
}
