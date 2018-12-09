using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : PlayerShoot
{
	//public float PowerTime;
	//public PowerUpManager PowerTime;
	public float PowerTime;

	private PowerUpManager ThePowerUpManager;
	

	// Use this for initialization
	void start ()
	{
		ThePowerUpManager = FindObjectOfType<PowerUpManager>();
	}
	void update ()
	{
		// if(PowerTime <= 0)
		// {
		// 	projectile.SetActive(false);
		// }
	}
	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.name == "Hero")
		{
			//ThePowerUpManager.ActivatePowerUp (PowerTime);
			projectile.SetActive(true);
			Destroy (gameObject);
			//PowerTime -= Time.deltaTime;
			ThePowerUpManager.ActivatePowerUp(PowerTime);
		}
		//gameObject.SetActive(false);
			
	}
}
