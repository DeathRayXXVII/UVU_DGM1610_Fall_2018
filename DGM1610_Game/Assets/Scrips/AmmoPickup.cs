using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : PlayerShoot
{
	// Use this for initialization
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.GetComponent<Rigidbody2D> () == null)
//			projectile = false;
			return;

		Destroy (gameObject);
	}
}
