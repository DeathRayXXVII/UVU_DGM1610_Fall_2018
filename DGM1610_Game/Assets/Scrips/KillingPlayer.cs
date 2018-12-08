using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillingPlayer : MonoBehaviour 
{
	public LevelManager LevelManager;
	public float TimeBetweenAttacks;
	public HeartUI HeartUI;
	public CharaterMove LocalPlayer;
	public PlayerShoot projectile;

	public int Damage;

	bool playerInRange;
	float time;

	// Use this for initialization
	void Start () 
	{
		LevelManager = FindObjectOfType <LevelManager>();
	}
	
	
	// Update is called once per frame
	/* void OnTriggerEnter2D (Collider2D other) 
	{
		//if(LocalPlayer.CurHealth >= 0)
			//LocalPlayer.CurHealth -= 1;
		if(other.name == "Hero")// && LocalPlayer.CurHealth <= 0)
			LevelManager.RespawnPlayer();
	}*/
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.name == "Hero")
		{
			if(LocalPlayer.CurHealth > 1)
			{
				LocalPlayer.CurHealth -= Damage;
			}
			if(LocalPlayer.CurHealth <= 0)
			{ 
				LevelManager.RespawnPlayer ();
				//projectile.SetActive(false);
			}
		}
	}
}
