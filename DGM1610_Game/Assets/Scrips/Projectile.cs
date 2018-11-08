﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour 
{
	public float Speed;
	public Rigidbody2D PC;

	public GameObject EnemyDeath;

	public GameObject PojectileParticle;

	public int PointsForKill;

	// Use this for initialization
	void Start () 
	{
		if (PC.transform.localScale.x < 0)
			Speed = -Speed;
	}
	
	// Update is called once per frame
	void Update () 
	{
		GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);

	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "Enemy")
		{
			Instantiate(PojectileParticle, transform.position, transform.rotation);
			Destroy (other.gameObject);
			ScoreManager.AddPoints (PointsForKill);
		}
		Destroy(gameObject);
	}
	void OnColllisionEnter2D(Collision2D other)
	{
		Instantiate(EnemyDeath, other.transform.position, other.transform.rotation);
		Destroy(gameObject);
	}
}
