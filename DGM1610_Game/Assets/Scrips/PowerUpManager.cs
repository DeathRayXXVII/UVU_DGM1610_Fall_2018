using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour 
{
	private bool powerupActive;
	private float PowerUpCounter;
	
	private PlayerShoot projectile;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(powerupActive)
		{
			PowerUpCounter -= Time.deltaTime;
			if(PowerUpCounter <= 0);
			{
				//projectile.SetActive(false);
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
