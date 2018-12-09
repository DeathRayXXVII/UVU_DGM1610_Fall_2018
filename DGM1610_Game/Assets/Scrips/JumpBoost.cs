using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoost : MonoBehaviour 
{
//public float jumpSpeed = 0f;
	public float thrust;
	public Rigidbody2D rb;

	private bool playerInZone;
	/*void Start ()
	{
		rb = GetComponent <Rigidbody2D>();
	}
	void OnTriggerEnter2D (Collider2D other)
	{
		Debug.Log ("Trigger");
		if (Input.GetKey (KeyCode.W)) 
		{
			rb.AddForce (transform.up * thrust);
		}
	}
	void FixedUpdate()
	{
		
	}*/
	void Start ()
	{
		rb = GetComponent <Rigidbody2D>();
		playerInZone = false;
	}
	void Update ()
	{
		if (playerInZone) 
		{
			rb.AddForce (transform.up * thrust);
		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log ("Trigger");
		if (other.name == "Hero") 
		{
			playerInZone = true;
		}
	}
}
