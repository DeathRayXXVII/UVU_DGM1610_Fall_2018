using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour 
{
	private bool powerupActive;
	private float PowerUpCounter;
	public float PowerTime;
	
	private PlayerShoot projectile;
	private LevelManager levelmanager;
	

	// Use this for initialization
	void Start () 
	{
		levelmanager = FindObjectOfType<LevelManager>();	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(powerupActive)
		{
			PowerUpCounter -= Time.deltaTime;

			if(levelmanager.powerupReset)
			{
				PowerUpCounter = 0;
				levelmanager.powerupReset = false;
			}

			if(PowerUpCounter <= 0);
			{
				powerupActive = false;
			}
		}
		
	}
	public void ActivatePowerUp(float time)
	{
		PowerUpCounter = time;
		powerupActive = true;
	}
}
